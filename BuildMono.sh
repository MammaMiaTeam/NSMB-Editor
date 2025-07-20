msbuild /t:Restore NSMBe5.sln
msbuild NSMBe5.sln /property:Configuration=Release
cp NSMBe5/app.config NSMBe5/bin/app_mono.config
sed -z -i 's/<System\.Windows\.Forms\.ApplicationConfigurationSection>.*<\/System\.Windows\.Forms\.ApplicationConfigurationSection>//' NSMBe5/bin/app_mono.config
#if [ -d "NSMBe5/bin/Debug" ];
#then
#cp NSMBe5/bin/app_mono.config NSMBe5/bin/Debug/NSMBe5.exe.config
#fi
if [ -d "NSMBe5/bin/Release" ];
then
cp NSMBe5/bin/app_mono.config NSMBe5/bin/Release/NSMBe5.exe.config
fi
rm NSMBe5/bin/app_mono.config
