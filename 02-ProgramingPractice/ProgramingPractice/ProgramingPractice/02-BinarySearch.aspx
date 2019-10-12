<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02-BinarySearch.aspx.cs" Inherits="ProgramingPractice._02_BinarySearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>What is binary Search?</h3>
            <p> <b>Binary Search:</b>
                Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering the whole array. If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half. Otherwise narrow it to the upper half. Repeatedly check until the value is found or the interval is empty.
            </p>
            <p>
                We basically ignore half of the elements just after one comparison.
                <ul>
                    <li>Compare x with the middle element.</li>
                    <li>If x matches with middle element, we return the mid index.</li>
                    <li>Else If x is greater than the mid element, then x can only lie in right half subarray after the mid element. So we recur for right half.</li>
                    <li>Else (x is smaller) recur for the left half.</li>
                    <li>mid = L + (R-L)/2</li>
                    <li>Rules</li>
                    <li>if arr[mid] > x then R= mid - 1  </li>
                    <li>if arr[mid] < x then L= mid + 1  </li>
                </ul>
            </p>
            <div>
                <h2>OUTPUT of Binary Search:</h2>
                <h3 runat="server" id="h2"></h3>
            </div>
        </div>
    </form>
</body>
</html>
