using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skorupi Specie to store common natural stats of every {'abilities': ['battle-armor', 'sniper', 'keen-eye'], 'base_experience': 66, 'height': 8, 'id': 451, 'moves': ['swords-dance', 'cut', 'whirlwind', 'sand-attack', 'headbutt', 'poison-sting', 'twineedle', 'pin-missile', 'leer', 'bite', 'strength', 'dig', 'toxic', 'agility', 'screech', 'double-team', 'confuse-ray', 'flash', 'rest', 'slash', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'feint-attack', 'sludge-bomb', 'mud-slap', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'taunt', 'brick-break', 'knock-off', 'secret-power', 'poison-fang', 'rock-tomb', 'aerial-ace', 'poison-tail', 'natural-gift', 'acupressure', 'payback', 'fling', 'toxic-spikes', 'poison-jab', 'dark-pulse', 'night-slash', 'aqua-tail', 'x-scissor', 'cross-poison', 'captivate', 'bug-bite', 'hone-claws', 'venoshock', 'round', 'struggle-bug', 'fell-stinger', 'confide', 'infestation'], 'name': 'skorupi', 'stats': {'hp': 40, 'attack': 50, 'defense': 90, 'special-attack': 30, 'special-defense': 55, 'speed': 65}, 'types': ['poison', 'bug'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'purple', 'shape': 'armor', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['bug', 'water3'], 'names': {'ja-Hrkt': 'スコルピ', 'roomaji': 'Scorpi', 'ko': '스콜피', 'zh-Hant': '鉗尾蠍', 'fr': 'Rapion', 'de': 'Pionskora', 'es': 'Skorupi', 'it': 'Skorupi', 'en': 'Skorupi', 'ja': 'スコルピ', 'zh-Hans': '钳尾蝎'}, 'genera': {'ja-Hrkt': 'さそりポケモン', 'ko': '전갈포켓몬', 'zh-Hant': '蠍子寶可夢', 'fr': 'Pokémon Scorpion', 'de': 'Skorpion', 'es': 'Pokémon Escorpión', 'it': 'Pokémon Scorpione', 'en': 'Scorpion Pokémon', 'ja': 'さそりポケモン', 'zh-Hans': '蝎子宝可梦'}}
	public class SpecieSkorupi : PokemonSpecie
	{
#nullable enable
		private static SpecieSkorupi? _instance = null;
#nullable restore
        public static SpecieSkorupi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkorupi();
                }
                return _instance;
            }
        }

		public SpecieSkorupi() : base(
			"Skorupi",
			40, // HPs
			50, 90, // Attack & Defense
			30, 55, // Special Attack & Defense
			65			
		) {}
	}


	//Skorupi Pokemon Class
	public class Skorupi : Pokemon
	{

		public Skorupi(string nickname, int level)
		: base(
				451,
				SpecieSkorupi.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skorupi(int level)
		: base(
				451,
				SpecieSkorupi.Instance, // Pokemon Specie
				"Skorupi", level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skorupi() : base(
			451,
			SpecieSkorupi.Instance, // Pokemon Specie
			Poison.Instance, Bug.Instance			
		) {}
	}
}