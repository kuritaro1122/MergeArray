public static class MergeArrayClass {
    public static T[] MergeArray<T>(T[] array1, params T[] array2) {
        int length1 = (array1 != null) ? array1.Length : 0;
        int length2 = (array2 != null) ? array2.Length : 0;
        T[] _array = new T[length1 + length2];
        int i = 0;
        for (int k = 0; k < length1; k++) {
            _array[i] = array1[k];
            i++;
        }
        for (int k = 0; k < length2; k++) {
            _array[i] = array2[k];
            i++;
        }
        return _array;
    }
    public static void MergeArray<T>(ref T[] array1, params T[] array2) {
        array1 = MergeArray(array1, array2);
    }
}