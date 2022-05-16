# poc-sns
Aws send SMS

AWS SNS


Create a Config class implements IConfig

![AWS](https://img.shields.io/badge/Amazon_AWS-FF9900?style=for-the-badge&logo=amazonaws&logoColor=white)


```
using Amazon;
namespace poc_sns
{
    public class Config : IConfig
    {
        public Config()
        {
        }

        public string AccessKey => "YOUR_AWS_ACCESS_KEY";

        public string SecretKey => "YOUR_AWS_SECRET_KEY";

        public string Number => "CEL_NUMBER";

        public RegionEndpoint RegionEndpoint => RegionEndpoint.USEast1;
    }
}
```

Run project
