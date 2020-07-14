## 撤销commit，不撤销git add  
git reset --soft HEAD^  

## 撤销commit，撤销git add，删除工作区代码  
git reset --hard HEAD^  

## 撤销commit，撤销git add，不删除工作区代码(默认)  
git reset --mixed HEAD^  