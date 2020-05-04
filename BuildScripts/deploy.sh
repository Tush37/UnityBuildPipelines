echo Clearning Up Build Directory
rm -rf ../TestProject/build/

echo Starting Build Process
'/c/Program Files/Unity/Hub/Editor/2018.4.22f1/Editor/Unity.exe' -quit -batchmode -projectPath ../TestProject/ -executeMethod BuildScript.PerformBuild
echo Ended Build Process
