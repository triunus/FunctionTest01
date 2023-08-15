/*using System;
using System.IO;

namespace FileIO
{
    public class CustomFileIO
    {
        public static bool LoadFromLocalFile<T>(string fileName, out T model) where T : class
        {
            return CustomFileIO.LoadFromFile<T>(fileName, FileIO.Instance, out model);
        }

        // out 키워드는 메소드 수행의 결과 값을 보여주는 것에 있어서, 매개변수를 사용하겠다는 뜻이다.
        // 따라서, return을 통해서 얻는 결과는 메소드 수행 성공여부이며, out T model이 성공적으로 수행되어 반환된 객체를 뜻한다.
        public static bool LoadFromFile<T>(string fileName, FileIO fileIO, out T model) where T : class
        {
            // 결과값을 반환할 객체 초기화
            model = default(T);

            if (!FileIO.Instance.FileExists(fileName))
            {
                return false;
            }
            try
            {
                // 제네릭으로 받은 T 객체의 선언 및 정의.
                T newObj = Activator.CreateInstance<T>();

                // fileName의 파일 읽어와서 stream으로 변환
                using (Stream stream = fileIO.FileReadStream(fileName))
                {
                    model = newObj
                }

            }
            return false;
        }

    }

    public class FileIO
    {
		// FileIO 객체를 static 형식으로 정의합니다.
        public static FileIO instance_;
        
		// Instacne를 통해 객체의 null 값을 확인한 후, 객체를 생성 및 반환합니다.
        public static FileIO Instance
        {
            get
            {
                if (FileIO.instance_ == null) FileIO.instance_ = new FileIO();
                return FileIO.instance_;
            }
        }

        // 하위 클래스에서 override 될 예정인 메소드들입니다.
        // 문자열을 받아 해당 경로에 파일을 만들어 저장합니다.
		public virtual void Write(string path, string text) { }
        // byte[]를 받아 해당 경로에 파일을 만듭니다.
		public virtual void Write(string path, byte[] bytes) { }
        // 해당 경로의 파일을 읽고, string으로 반환합니다.
		public virtual string ReadText(string path) { return null; }
        // 해당 경로의 파일을 읽고, byte[]으로 반환합니다.
		public virtual byte[] Read(string path) { return null; }
        // file.close()를 확인???
		public virtual bool FileExists(string path) { return false; }
        // 해당 경로의 파일을 읽고, stream 형식으로 반환합니다.
		public virtual Stream FileReadStream(string path)
		{
			byte[] array = this.Read(path);
			return new MemoryStream(array, 0, array.Length);
		}
	}
}*/