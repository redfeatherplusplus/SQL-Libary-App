# Author: Daren Cheng
# Class: CS 6350
# Date: 9/27/2016
# 
# Desc: Removes all non-printable lines from a CSV file

import string

# defined constants
printable = set(string.printable)

# note: set(string.printable) for my computer yields: 
# set(['\x0c', ' ', '$', '(', ',', '0', '4', '8', '<', '@', 'D', 'H', 'L', 'P', 'T
# ', 'X', '\\', '`', 'd', 'h', 'l', 'p', 't', 'x', '|', '\x0b', '#', "'", '+', '/'
# , '3', '7', ';', '?', 'C', 'G', 'K', 'O', 'S', 'W', '[', '_', 'c', 'g', 'k', 'o'
# , 's', 'w', '{', '\n', '"', '&', '*', '.', '2', '6', ':', '>', 'B', 'F', 'J', 'N
# ', 'R', 'V', 'Z', '^', 'b', 'f', 'j', 'n', 'r', 'v', 'z', '~', '\t', '\r', '!',
# '%', ')', '-', '1', '5', '9', '=', 'A', 'E', 'I', 'M', 'Q', 'U', 'Y', ']', 'a',
# 'e', 'i', 'm', 'q', 'u', 'y', '}'])

def main(filepath): 
	# read lines from the file
	file = open(filepath, "r")
	lines = file.readlines()
	file.close()
	
	# write back only lines that are printable
	file = open(filepath, "w")
	for line in lines:
		if isPrintable(line):
			file.write(line)
	file.close()

def isPrintable(line):
	for word in line:
		for char in word:
			if char not in printable:
				return False
	
	return True

if __name__ == '__main__':
	main("C:\\Users\\Cheng\\Downloads\\books_01.csv")