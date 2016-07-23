using AutoMapper;


namespace CMS.DTO
{
    public class BaseFactory<T, TDTO>
    {
        public TDTO Map(T t)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<T, TDTO>());
            return Mapper.Map<TDTO>(t);
        }

        public T Map(TDTO tDto)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TDTO, T>());
            return Mapper.Map<T>(tDto);
        }
    }
}
