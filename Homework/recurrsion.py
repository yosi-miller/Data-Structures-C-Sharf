# Q-1
def multiply(num1: int, num2: int, result: int=0) -> int:
    if num2 == 0:
        return result
    result += num1
    return multiply(num1, num2 - 1, result)

# Q-2
def sumOfDigits(num: int) -> int:
    # result = 0
    # for digit in range(num):
    #     result += int(digit)
    if num == 0:
        return 0
    else:
        return num %  10 + sumOfDigits(num // 10)

# Q-3
def power(num1: int, num2: int, result: int=1) -> int:
    if num2 == 0:
        return result
    result *= num1
    return power(num1, num2 - 1, result)


if __name__ == '__main__':
    # print(multiply(2, 3))
    # print(sumOfDigits(32001))
    print(power(2, 3))