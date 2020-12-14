FROM centos:centos7

COPY ./src app/

RUN yum update -y

# .net core SDKをインストール
RUN rpm -Uvh https://packages.microsoft.com/config/centos/8/packages-microsoft-prod.rpm
RUN yum install -y dotnet-sdk-2.1

# node,npmをインストール
RUN curl -sL https://rpm.nodesource.com/setup_14.x | bash -
RUN yum install -y nodejs
RUN npm update -g npm

# gitをインストール
RUN yum -y install https://repo.ius.io/ius-release-el7.rpm https://dl.fedoraproject.org/pub/epel/epel-release-latest-7.noarch.rpm
RUN yum -y install libsecret pcre2 perl perl-Error perl-TermReadKey openssh-clients less emacs-filesystem
RUN yum -y install git --enablerepo=ius --disablerepo=base,epel,extras,updates

WORKDIR /app
RUN dotnet restore
