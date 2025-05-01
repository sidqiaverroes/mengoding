//2071. Maximum Number of Tasks You Can Assign
//1 May 2025

public class Solution
{
    public int MaxTaskAssign(int[] taskRequirements, int[] workerStrengths, int availablePills, int pillStrengthBoost)
    {
        // Sort task requirements and worker strengths in descending order for optimal assignment
        Array.Sort(taskRequirements, (a, b) => b.CompareTo(a));    
        Array.Sort(workerStrengths, (a, b) => b.CompareTo(a));     

        int taskIndex = 0;
        int workerIndex = 0;
        int pillWorkerPointer = 0;
        int completedTasks = 0;
        bool scanningDown = true;

        var pillQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a))); // Max-Heap to manage workers needing pills

        while (taskIndex < taskRequirements.Length)
        {
            // CASE 1: Skip workers who are already assigned tasks
            while (workerIndex < workerStrengths.Length && workerStrengths[workerIndex] == -1) 
                workerIndex++;

            // CASE 2: No more normal workers available, try to complete the task with a pill-assisted worker
            if (workerIndex >= workerStrengths.Length)
            {
                if (pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue(); // Complete the task with a pill-assisted worker
                    completedTasks++;
                }
            }
            // CASE 3: A normal worker can complete the task without a pill
            else if (workerStrengths[workerIndex] >= taskRequirements[taskIndex])
            {
                workerStrengths[workerIndex] = -1; // Mark worker as assigned
                workerIndex++;
                completedTasks++;
            }
            else
            {
                // CASE 4: If worker can't complete task without a pill, attempt to assign a pill-assisted worker
                if (scanningDown)
                {
                    // Scan for the first worker who can complete the task with a pill
                    while (pillWorkerPointer < workerStrengths.Length &&
                           (workerStrengths[pillWorkerPointer] == -1 || workerStrengths[pillWorkerPointer] + pillStrengthBoost >= taskRequirements[taskIndex]))
                    {
                        pillWorkerPointer++;
                    }

                    // CASE 5: If no worker found, switch scanning direction
                    if (pillWorkerPointer == workerStrengths.Length)
                    {
                        scanningDown = false;
                        pillWorkerPointer = workerStrengths.Length - 1;
                    }
                }

                // CASE 6: If no worker can complete the task with a pill, try to use the pill queue
                while (pillWorkerPointer >= workerStrengths.Length || 
                      (pillWorkerPointer > workerIndex && 
                      (workerStrengths[pillWorkerPointer] == -1 || workerStrengths[pillWorkerPointer] + pillStrengthBoost < taskRequirements[taskIndex])))
                {
                    pillWorkerPointer--;
                }

                // CASE 7: Try completing the task with a worker from the pill queue
                if (pillQueue.Count >= availablePills && pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue(); // Complete the task with a pill-assisted worker
                    completedTasks++;
                }
                // CASE 8: A worker with a pill can complete the task, assign the task to them
                else if (pillWorkerPointer >= 0 && workerStrengths[pillWorkerPointer] + pillStrengthBoost >= taskRequirements[taskIndex])
                {
                    pillQueue.Enqueue(workerStrengths[pillWorkerPointer], workerStrengths[pillWorkerPointer]);
                    workerStrengths[pillWorkerPointer] = -1; // Mark the worker as assigned
                    pillWorkerPointer = scanningDown ? pillWorkerPointer - 1 : pillWorkerPointer + 1;
                }
                // CASE 9: If there are pill-assisted workers in the queue, complete the task
                else if (pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue(); // Complete the task with a pill-assisted worker
                    completedTasks++;
                }
            }

            taskIndex++; // Move to the next task
            pillWorkerPointer = Math.Max(pillWorkerPointer, workerIndex); // Ensure pointer doesn't lag behind available workers
        }

        // Return the total number of completed tasks, considering any remaining workers in the pill queue
        return completedTasks + Math.Min(pillQueue.Count, availablePills);
    }
}