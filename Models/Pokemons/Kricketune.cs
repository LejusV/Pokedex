using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kricketune Specie to store common natural stats of every {'abilities': ['swarm', 'technician'], 'base_experience': 134, 'height': 10, 'id': 402, 'moves': ['swords-dance', 'cut', 'growl', 'sing', 'hyper-beam', 'strength', 'absorb', 'string-shot', 'toxic', 'screech', 'double-team', 'focus-energy', 'bide', 'leech-life', 'flash', 'rest', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'perish-song', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'taunt', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'hyper-voice', 'silver-wind', 'aerial-ace', 'natural-gift', 'night-slash', 'x-scissor', 'bug-buzz', 'giga-impact', 'captivate', 'bug-bite', 'hone-claws', 'round', 'echoed-voice', 'struggle-bug', 'sticky-web', 'fell-stinger', 'confide', 'infestation', 'power-up-punch'], 'name': 'kricketune', 'stats': {'hp': 77, 'attack': 85, 'defense': 51, 'special-attack': 55, 'special-defense': 51, 'speed': 65}, 'types': ['bug'], 'weight': 255, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コロトック', 'roomaji': 'Korotok', 'ko': '귀뚤톡크', 'zh-Hant': '音箱蟀', 'fr': 'Mélokrik', 'de': 'Zirpeise', 'es': 'Kricketune', 'it': 'Kricketune', 'en': 'Kricketune', 'ja': 'コロトック', 'zh-Hans': '音箱蟀'}, 'genera': {'ja-Hrkt': 'こおろぎポケモン', 'ko': '귀뚜라미포켓몬', 'zh-Hant': '蟋蟀寶可夢', 'fr': 'Pokémon Criquet', 'de': 'Zirper', 'es': 'Pokémon Grillo', 'it': 'Pokémon Grillo', 'en': 'Cricket Pokémon', 'ja': 'こおろぎポケモン', 'zh-Hans': '蟋蟀宝可梦'}}
	public class SpecieKricketune : PokemonSpecie
	{
#nullable enable
		private static SpecieKricketune? _instance = null;
#nullable restore
        public static SpecieKricketune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKricketune();
                }
                return _instance;
            }
        }

		public SpecieKricketune() : base(
			"Kricketune",
			77, // HPs
			85, 51, // Attack & Defense
			55, 51, // Special Attack & Defense
			65			
		) {}
	}


	//Kricketune Pokemon Class
	public class Kricketune : Pokemon
	{

		public Kricketune(string nickname, int level) : base(
			402,
			SpecieKricketune.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Kricketune() : base(
			402,
			SpecieKricketune.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}