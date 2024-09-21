namespace Achieve.QuickSave
{
    public sealed partial class QuickSave<T>
    {
        /// <summary>
        /// �����͸� �����մϴ�.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void SaveData<T>(T data) => SaveDataInternal(data);

        /// <summary>
        /// �����͸� �ε��ϸ�, �ε��� ��ü�� ��ȯ�մϴ�.
        /// </summary>
        /// <returns></returns>
        public T LoadData() => LoadDataInternal();
    }
}
