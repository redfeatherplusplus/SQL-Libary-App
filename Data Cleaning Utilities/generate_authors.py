# Author: Daren Cheng
# Class: CS 6350
# Date: 9/27/2016
# 
# Desc: Generates authors.csv from the normalized books.csv

import re

# defined constants
derived_table_name = "authors.csv"
ISBN10 = 0
ISBN13 = 1
Title = 2
Author = 3
Cover = 4
Publisher = 5
Pages = 6

authors = []
authors_lowercase = []

def main(filepath): 
	# read lines from the file
	file = open(filepath, "r")
	lines = file.readlines()
	file.close()
	
	# derive the appropriate tuples from each line
	for line in lines:
		derive_tuples(line)
	
	# write each author to the output file
	filepath = "\\".join(filepath.split("\\")[:-1]) + "\\" + derived_table_name
	file = open(filepath, "w")
		
	column_headers = "	".join(["Author_id", "Name"]) + "\n"
	file.write(column_headers)
	
	for author in authors[1:]:
		author_tuple = "	".join([str(authors.index(author)), author]) + "\n"
		file.write(author_tuple)

def derive_tuples(line):
	books_tuple = line.split("	")
	book_authors = re.split(", |; |,|;", books_tuple[Author])
	for author in book_authors:
		if author.lower() not in authors_lowercase:
			authors.append(author)
			authors_lowercase.append(author.lower())
		else:
			author_index = authors_lowercase.index(author.lower())
			
			# In string comparison of two exact same strings, the
			# one with more capital letters will have a lower order
			# we want the author name with the most capital letters
			if author < authors[author_index]:
				authors[author_index] = author

if __name__ == '__main__':
	main("C:\\Users\\Cheng\\Downloads\\books_03.csv")