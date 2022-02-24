using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Archen Specie to store common natural stats of every {'abilities': ['defeatist'], 'base_experience': 71, 'height': 5, 'id': 566, 'moves': ['cut', 'wing-attack', 'thrash', 'leer', 'bite', 'roar', 'rock-throw', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'sandstorm', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bounce', 'roost', 'pluck', 'tailwind', 'u-turn', 'rock-polish', 'aqua-tail', 'dragon-pulse', 'earth-power', 'switcheroo', 'shadow-claw', 'zen-headbutt', 'defog', 'stone-edge', 'stealth-rock', 'head-smash', 'hone-claws', 'smack-down', 'round', 'quick-guard', 'ally-switch', 'acrobatics', 'bulldoze', 'confide'], 'name': 'archen', 'stats': {'hp': 55, 'attack': 112, 'defense': 45, 'special-attack': 74, 'special-defense': 45, 'speed': 70}, 'types': ['rock', 'flying'], 'weight': 95, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['flying', 'water3'], 'names': {'ja-Hrkt': 'アーケン', 'ko': '아켄', 'zh-Hant': '始祖小鳥', 'fr': 'Arkéapti', 'de': 'Flapteryx', 'es': 'Archen', 'it': 'Archen', 'en': 'Archen', 'ja': 'アーケン', 'zh-Hans': '始祖小鸟'}, 'genera': {'ja-Hrkt': 'さいこどりポケモン', 'ko': '최초새포켓몬', 'zh-Hant': '遠古鳥寶可夢', 'fr': 'Pokémon Oisancien', 'de': 'Urzeitvogel', 'es': 'Pokémon Protopájaro', 'it': 'Pokémon Paleouccello', 'en': 'First Bird Pokémon', 'ja': 'さいこどりポケモン', 'zh-Hans': '远古鸟宝可梦'}}
	public class SpecieArchen : PokemonSpecie
	{
#nullable enable
		private static SpecieArchen? _instance = null;
#nullable restore
        public static SpecieArchen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArchen();
                }
                return _instance;
            }
        }

		public SpecieArchen() : base(
			"Archen",
			55, // HPs
			112, 45, // Attack & Defense
			74, 45, // Special Attack & Defense
			70			
		) {}
	}


	//Archen Pokemon Class
	public class Archen : Pokemon
	{

		public Archen(string nickname, int level)
		: base(
				566,
				SpecieArchen.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Archen(int level)
		: base(
				566,
				SpecieArchen.Instance, // Pokemon Specie
				"Archen", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Archen() : base(
			566,
			SpecieArchen.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
	}
}