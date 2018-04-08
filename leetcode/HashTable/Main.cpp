//## 对于散列表的学习一
//表包括——顺序表（数组）、单向链表、双向链表、循环链表、hashtable

//hashtable的用处
//新华字典，如果知道读音，可以二分查找很快定位，但是不知道读音就需要顺序查找，很慢。


//hash可以实现高效的数据存储和查找

//最大的特点——数据存储位置和数据内容相关
//offset = hash(key);
//offset可以理解为存储位置，key可以理解为是内容的关键字。
//hash为散列函数，hash函数的内容是数据记录的关键字——key。

//struct access_record_t {
//	unsigned index_i;
//	char country_name[Max_Country_Name_Length];
//	unsigned long long access_count;
//};
////中国的代号是86
//access_record_t[86].access_count 可以获知中国大陆的访问量。
//
//散列函数千千万，都会遇到hash_collusion问题


//## 对于散列表的学习二
//特性：使用key检索value，而不是用绝对地址。
//内部无顺序，每一个key对应一个value。

//unordered_map使用的就是hashtable这种结构

//用hash_bucket来理解hash_table
//为了每一个hash_value，建立一个hash_bucket


//无序表的使用
//主要是用于数据的查找，


//在C#中
//key 和 value的对应就是hashmap和hashtable。
//暂时我们使用的还是HashTable，是Dictionary的派生类
//暂时不要用hashMap因为是Map接口的一个实现类。


