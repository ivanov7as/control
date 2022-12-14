package com.company;

public class Main {

    public static void main(String[] args) {
        class SolutionMaxAreaOfIsland {

            public int maxAreaOfIsland(int[][] grid) {
                int max = 0;
                for (int i = 0; i < grid.length; ++i) {
                    for (int j = 0; j < grid[0].length; ++j) {
                        max = Math.max(max, dfs(grid, i, j));
                    }
                }
                return max;
            }

            public int dfs(int[][] grid, int i, int j) {
                if (i < 0 || i == grid.length || j < 0 || j == grid[0].length) return 0;
                if (grid[i][j] != 1) return 0;
                grid[i][j] = 0;
                return 1 + dfs(grid, i + 1, j) + dfs(grid, i - 1, j) + dfs(grid, i, j + 1) + dfs(grid, i, j - 1);
            }
        }
        class TreeNode {
            int val;
            TreeNode left;
            TreeNode right;

            TreeNode() {
            }

            TreeNode(int val) {
                this.val = val;
            }

            TreeNode(int val, TreeNode left, TreeNode right) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        class SolutionIsSymmetric {
            public boolean isSymmetric(TreeNode root) {
                return isSymmetric(root, root);
            }

            private boolean isSymmetric(TreeNode p, TreeNode q) {
                if (p == null || q == null) return p == q;
                return p.val == q.val && isSymmetric(p.left, q.right) && isSymmetric(p.right, q.left);
            }
        }
    }
}
