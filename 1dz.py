package com.company;

public class Main {

    public static void main(String[] args) {
        
        class Solution1 {
            public String mergeAlternately(String word1, String word2) {
                int l1 = word1.length();
                int l2 = word2.length();
                if (l1 > l2) {
                    l1 = l2;
                }
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < l1; ++i) {
                    output.append(word1.charAt(i));
                    output.append(word2.charAt(i));
                }
                return output.append(word1.substring(l1)).append(word2.substring(l1)).toString();
            }
        }

        class Solution4 {
            public String reverseWords(String s) {
                StringBuilder sb = new StringBuilder();
                int end = s.length() - 1;
                while (end >= 0) {
                    if (s.charAt(end) == ' ') {
                        end -= 1;
                        continue;
                    }
                    int start = end - 1;
                    while (start >= 0 && s.charAt(start) != ' ') {
                        start -= 1;
                    }
                    sb.append(" ");
                    sb.append(s.substring(start + 1, end + 1));
                    end = start - 1;
                }
                if (sb.length() > 0) {
                    sb.deleteCharAt(0);
                }
                return sb.toString();
            }
        }

        class Solution5 {
            public boolean isPalindrome(String s) {
                for (int left = 0, right = s.length() - 1; left < right; left++, right--) {
                    while (left < right && !Character.isLetterOrDigit(s.charAt(left))) {
                        left++;
                    }
                    while (left < right && !Character.isLetterOrDigit(s.charAt(right))) {
                        right--;
                    }
                    if (left < right && Character.toLowerCase(s.charAt(left)) != Character.toLowerCase(s.charAt(right))) {
                        return false;
                    }
                }
                return true;
            }
        }

        class Solution2 {
            public int removeElement(int[] nums, int val) {
                int n = 0;
                for (int i : nums)
                    if (i != val)
                        nums[n++] = i;
                return n;
            }

        }
    }
}
