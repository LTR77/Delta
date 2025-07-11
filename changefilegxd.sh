#!/bin/bash
find . -type f -name "*.cs" -exec vim -c "%s/GorillaX/Delta/g" -c "wq" {} \;
