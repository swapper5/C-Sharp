using System;
using System.Collections.Generic;

public class Solution {
    public static int[][] MergeIntervals(int[][] intervals) {
        try {
            if(intervals == null || intervals.Length == 0) {
                return new int[0][];
            }

            Array.Sort(intervals, (a,b) => a[0] - b[0]);

            List<int[]> mergedIntervals = new List<int[]>();

            foreach(int[] interval in intervals) {
                if(mergedIntervals.Count == 0 || interval[0] > mergedIntervals[mergedIntervals.Count - 1][1]) {
                    mergedIntervals.Add(interval);
                } else {
                    mergedIntervals[mergedIntervals.Count - 1][1] = Math.Max(mergedIntervals[mergedIntervals.Count - 1][1], interval[1]);
                }
            }

            return mergedIntervals.ToArray();
        } catch(Exception ex) {
            Console.WriteLine("An error occurred: " + ex.Message);
            return null;
        }
    }
    
    public static void Main() {
        int[][] intervals = new int[][] {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };
        
        int[][] result = MergeIntervals(intervals);
        
        Console.WriteLine("Merged intervals:");
        foreach(int[] interval in result) {
            Console.WriteLine("[" + interval[0] + ", " + interval[1] + "]");
        }
    }
}
