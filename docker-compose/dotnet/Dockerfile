FROM centos:centos7

COPY app/ app/
WORKDIR /app

RUN yum update -y
RUN rpm -Uvh https://packages.microsoft.com/config/centos/8/packages-microsoft-prod.rpm
RUN yum install -y dotnet-sdk-2.1
RUN dotnet publish

ENTRYPOINT ["dotnet", "watch", "run"]
