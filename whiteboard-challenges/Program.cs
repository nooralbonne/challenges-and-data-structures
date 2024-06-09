Function FindMostFrequentNumber(nums):
    mostFrequentNumber = None
    maxCount = 0

    For each num in nums:
        currentCount = CountOccurrences(nums, num)
        If currentCount > maxCount:
            mostFrequentNumber = num
            maxCount = currentCount

    Return mostFrequentNumber
