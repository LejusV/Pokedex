using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Growlithe Specie to store common natural stats of every {'abilities': ['intimidate', 'flash-fire', 'justified'], 'base_experience': 70, 'height': 7, 'id': 58, 'moves': ['double-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'strength', 'dragon-rage', 'fire-spin', 'dig', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'thief', 'flame-wheel', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'morning-sun', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'helping-hand', 'secret-power', 'overheat', 'odor-sleuth', 'aerial-ace', 'howl', 'covet', 'natural-gift', 'close-combat', 'flare-blitz', 'fire-fang', 'captivate', 'flame-burst', 'flame-charge', 'round', 'incinerate', 'retaliate', 'wild-charge', 'snarl', 'confide', 'burn-up'], 'name': 'growlithe', 'stats': {'hp': 55, 'attack': 70, 'defense': 45, 'special-attack': 70, 'special-defense': 50, 'speed': 60}, 'types': ['fire'], 'weight': 190, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 190, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ガーディ', 'roomaji': 'Gardie', 'ko': '가디', 'zh-Hant': '卡蒂狗', 'fr': 'Caninos', 'de': 'Fukano', 'es': 'Growlithe', 'it': 'Growlithe', 'en': 'Growlithe', 'ja': 'ガーディ', 'zh-Hans': '卡蒂狗'}, 'genera': {'ja-Hrkt': 'こいぬポケモン', 'ko': '강아지포켓몬', 'zh-Hant': '小狗寶可夢', 'fr': 'Pokémon Chiot', 'de': 'Hund', 'es': 'Pokémon Perrito', 'it': 'Pokémon Cagnolino', 'en': 'Puppy Pokémon', 'ja': 'こいぬポケモン', 'zh-Hans': '小狗宝可梦'}}
	public class SpecieGrowlithe : PokemonSpecie
	{
#nullable enable
		private static SpecieGrowlithe? _instance = null;
#nullable restore
        public static SpecieGrowlithe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrowlithe();
                }
                return _instance;
            }
        }

		public SpecieGrowlithe() : base(
			"Growlithe",
			55, // HPs
			70, 45, // Attack & Defense
			70, 50, // Special Attack & Defense
			60			
		) {}
	}


	//Growlithe Pokemon Class
	public class Growlithe : Pokemon
	{

		public Growlithe(string nickname, int level)
		: base(
				58,
				SpecieGrowlithe.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Growlithe(int level)
		: base(
				58,
				SpecieGrowlithe.Instance, // Pokemon Specie
				"Growlithe", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Growlithe() : base(
			58,
			SpecieGrowlithe.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}