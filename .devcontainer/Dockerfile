FROM mcr.microsoft.com/dotnet/sdk:8.0

RUN wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && rm packages-microsoft-prod.deb

RUN apt-get update && apt-get install -y \
    libncurses5-dev \
    procps less

RUN apt-get install -y task-japanese locales locales-all \
  && locale-gen ja_JP.UTF-8 \
  && echo "export LANG=ja_JP.UTF-8" >> /root/.bashrc

RUN apt-get clean \
    && rm -rf /var/lib/apt/lists/*

CMD [ "/bin/bash" ]