using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Archeops Specie to store common natural stats of every {'abilities': ['defeatist'], 'base_experience': 177, 'height': 14, 'id': 567, 'moves': ['cut', 'wing-attack', 'fly', 'thrash', 'leer', 'roar', 'hyper-beam', 'rock-throw', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'sky-attack', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'outrage', 'sandstorm', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bounce', 'roost', 'pluck', 'tailwind', 'u-turn', 'rock-polish', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'stone-edge', 'stealth-rock', 'hone-claws', 'smack-down', 'round', 'quick-guard', 'acrobatics', 'bulldoze', 'dragon-tail', 'confide'], 'name': 'archeops', 'stats': {'hp': 75, 'attack': 140, 'defense': 65, 'special-attack': 112, 'special-defense': 65, 'speed': 110}, 'types': ['rock', 'flying'], 'weight': 320, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['flying', 'water3'], 'names': {'ja-Hrkt': 'アーケオス', 'ko': '아케오스', 'zh-Hant': '始祖大鳥', 'fr': 'Aéroptéryx', 'de': 'Aeropteryx', 'es': 'Archeops', 'it': 'Archeops', 'en': 'Archeops', 'ja': 'アーケオス', 'zh-Hans': '始祖大鸟'}, 'genera': {'ja-Hrkt': 'さいこどりポケモン', 'ko': '최초새포켓몬', 'zh-Hant': '遠古鳥寶可夢', 'fr': 'Pokémon Oisancien', 'de': 'Urzeitvogel', 'es': 'Pokémon Protopájaro', 'it': 'Pokémon Paleouccello', 'en': 'First Bird Pokémon', 'ja': 'さいこどりポケモン', 'zh-Hans': '远古鸟宝可梦'}}
	public class SpecieArcheops : PokemonSpecie
	{
#nullable enable
		private static SpecieArcheops? _instance = null;
#nullable restore
        public static SpecieArcheops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArcheops();
                }
                return _instance;
            }
        }

		public SpecieArcheops() : base(
			"Archeops",
			75, // HPs
			140, 65, // Attack & Defense
			112, 65, // Special Attack & Defense
			110			
		) {}
	}


	//Archeops Pokemon Class
	public class Archeops : Pokemon
	{

		public Archeops(string nickname, int level)
		: base(
				567,
				SpecieArcheops.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Archeops(int level)
		: base(
				567,
				SpecieArcheops.Instance, // Pokemon Specie
				"Archeops", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Archeops() : base(
			567,
			SpecieArcheops.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
	}
}