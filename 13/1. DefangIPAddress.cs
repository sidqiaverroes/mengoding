//leetcode 1108. Defanging an IP Address

public class Solution
{
    public string DefangIPaddr(string address) {
        string[] arr = address.Split(".");

        return String.Join("[.]", arr);
    }
}