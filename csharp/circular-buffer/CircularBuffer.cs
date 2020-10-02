using System;

public class CircularBuffer<T>
{
    private T[] _buffer;
    private int _startPointer = 0;
    private int _endPointer = 0;
    private int _countInBuffer = 0;
    
    public CircularBuffer(int capacity)
    {
        _buffer = new T[capacity];
    }

    public T Read()
    {
        if (_countInBuffer == 0)
        {
            throw new InvalidOperationException("Can't read an empty buffer");
        }
        T value = _buffer[_startPointer];
        _startPointer = NextIndex(_startPointer);
        _countInBuffer --;

        return value;
    }

    public void Write(T value)
    {
        if (_countInBuffer == _buffer.Length)
        {
            throw new InvalidOperationException("Can't write to a full buffer.");
        }
        _buffer[_endPointer] = value;
        _endPointer = NextIndex(_endPointer);
        _countInBuffer ++;
    }

    public void Overwrite(T value)
    {
        if (_countInBuffer == _buffer.Length)
        {
            _countInBuffer --;
            _startPointer = NextIndex(_startPointer);
        }
        Write(value);
    }

    public void Clear()
    {
        if (_countInBuffer > 0)
        {
            Array.Clear(_buffer, _startPointer, 1);
            _countInBuffer --;
        }
    }

    private int NextIndex(int index) => ++index % _buffer.Length;
}