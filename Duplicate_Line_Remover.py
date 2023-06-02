def remove_duplicates(filename):
    lines = open(filename, 'r').readlines()
    lines_set = set(lines)
    out = open(filename, 'w')
    for line in lines_set:
        out.write(line)

remove_duplicates('yourfile.txt')