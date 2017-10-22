## We're gonna use Breadth First Search as a heuristic. You pick a vertex, put it to the furthest left, then do a BFS on it. 
#You then list the order of the vertexes and give the longest length. It's not a perfect algorithm but it works often
from collections import deque
listOfVertex = []
reducedListOfVertex = []

def initialV(graph):
    for v in graph:
        listOfVertex.append(v)
    return listOfVertex

def BFS(graph, start):
    reducedListOfVertex.append(start)
    color, dist, parent = {}, {}, {} #initialize statistics dictionaries
    for v in graph:
        listOfVertex.append(v)
        color[v] = 'green'
        dist[v] = 'inf'
        parent[v] = -1
    color[start] = 'yellow'
    dist[start] = 0
    queue = deque([start])
    while queue:
        u = queue.popleft() # or without deque, use: u = queue.pop(0) 
        for v in graph[u]:
            if color[v] == 'green':
                color[v] = 'yellow'
                dist[v] = dist[u]+1
                parent[v] = u
                queue.append(v)
                reducedListOfVertex.append(v)
        color[u] = 'red'
    return reducedListOfVertex

def longestLength(G, v):
    maxLength = 0
    for i in v:
        for j in G[i]:
            if (v.index(j) - v.index(i)) > maxLength:
                maxLength = v.index(j) - v.index(i)
    return maxLength

def findStart(graph):
    bestLength = len(graph)
    for i in graph:
        findStart = i
        BFS(graph, findStart)
        if (longestLength(graph, BFS(graph, findStart)) < bestLength):
            bestLength = longestLength(graph, BFS(graph, findStart))
    return bestLength

# A graph to test on:
G = { 
      1:[8],
      2:[7,8],
      3:[6,7],
      4:[5],
      5:[4, 6],
      6:[3, 4],
      7:[2,3],
      8:[1,2]
    }
start = findStart(G)
print ("The number you will start on to form the best reduction is " + str(start))
reducedListOfVertex = []
listOfVertex = []
print ("Before reduction:" + str(initialV(G)))
print ("After reduction: " + str(BFS(G, start)))
reducedListOfVertex = []
if(longestLength(G, BFS(G, start)) == 1):
    print ("Longest length is 1! Graph is completely reduced.")
else:
    print ("Longest length is " + str(longestLength(G, BFS(G, start))) + ". Graph is not perfectly reduced.")
