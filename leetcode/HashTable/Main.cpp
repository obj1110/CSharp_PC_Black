//## ����ɢ�б��ѧϰһ
//���������˳������飩����������˫������ѭ������hashtable

//hashtable���ô�
//�»��ֵ䣬���֪�����������Զ��ֲ��Һܿ춨λ�����ǲ�֪����������Ҫ˳����ң�������


//hash����ʵ�ָ�Ч�����ݴ洢�Ͳ���

//�����ص㡪�����ݴ洢λ�ú������������
//offset = hash(key);
//offset�������Ϊ�洢λ�ã�key�������Ϊ�����ݵĹؼ��֡�
//hashΪɢ�к�����hash���������������ݼ�¼�Ĺؼ��֡���key��

//struct access_record_t {
//	unsigned index_i;
//	char country_name[Max_Country_Name_Length];
//	unsigned long long access_count;
//};
////�й��Ĵ�����86
//access_record_t[86].access_count ���Ի�֪�й���½�ķ�������
//
//ɢ�к���ǧǧ�򣬶�������hash_collusion����


//## ����ɢ�б��ѧϰ��
//���ԣ�ʹ��key����value���������þ��Ե�ַ��
//�ڲ���˳��ÿһ��key��Ӧһ��value��

//unordered_mapʹ�õľ���hashtable���ֽṹ

//��hash_bucket�����hash_table
//Ϊ��ÿһ��hash_value������һ��hash_bucket


//������ʹ��
//��Ҫ���������ݵĲ��ң�


//��C#��
//key �� value�Ķ�Ӧ����hashmap��hashtable��
//��ʱ����ʹ�õĻ���HashTable����Dictionary��������
//��ʱ��Ҫ��hashMap��Ϊ��Map�ӿڵ�һ��ʵ���ࡣ


