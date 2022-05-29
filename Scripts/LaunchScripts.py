import os

# install requests library
print(f"Checking for 'requests' library")
if not os.system(f"pip install requests | grep requests"):
    print(f'pip install requests')
    os.system(f"pip install requests")

print(f"Checking for 'requests' library")
if not os.system(f"pip install requests | grep requests"):
    print(f'pip install requests')
    os.system(f"pip install requests")

print(f'Generating Enums...')
os.system(f"py Scripts/EnumGenerator.py")
print(f'Done')
print(f'Generating Moves...')
os.system(f"py Scripts/MoveGenerator.py")
print(f'Done')
print(f'Generating Pokemons...')
os.system(f"py Scripts/PokemonGenerator.py")
print(f'Done')
print(f'Generating Types...')
os.system(f"py Scripts/TypeGenerator.py")
print(f'Done')