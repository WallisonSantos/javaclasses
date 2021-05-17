ABRINDO UM REPOSITÓRIO REMOTO CRIADO NO GITHUB:

echo "# javaclasses" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/WallisonSantos/javaclasses.git
git push -u origin main