using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Noctowl Specie to store common natural stats of every {'abilities': ['insomnia', 'keen-eye', 'tinted-lens'], 'base_experience': 158, 'height': 16, 'id': 164, 'moves': ['fly', 'tackle', 'take-down', 'double-edge', 'growl', 'hyper-beam', 'peck', 'toxic', 'confusion', 'psychic', 'hypnosis', 'mimic', 'double-team', 'reflect', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'heat-wave', 'facade', 'magic-coat', 'recycle', 'secret-power', 'hyper-voice', 'air-cutter', 'silver-wind', 'extrasensory', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'psycho-shift', 'air-slash', 'giga-impact', 'zen-headbutt', 'defog', 'captivate', 'ominous-wind', 'synchronoise', 'round', 'echoed-voice', 'work-up', 'moonblast', 'confide'], 'name': 'noctowl', 'stats': {'hp': 100, 'attack': 50, 'defense': 50, 'special-attack': 86, 'special-defense': 96, 'speed': 70}, 'types': ['normal', 'flying'], 'weight': 408, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ヨルノズク', 'roomaji': 'Yorunozuku', 'ko': '야부엉', 'zh-Hant': '貓頭夜鷹', 'fr': 'Noarfang', 'de': 'Noctuh', 'es': 'Noctowl', 'it': 'Noctowl', 'en': 'Noctowl', 'ja': 'ヨルノズク', 'zh-Hans': '猫头夜鹰'}, 'genera': {'ja-Hrkt': 'ふくろうポケモン', 'ko': '부엉이포켓몬', 'zh-Hant': '貓頭鷹寶可夢', 'fr': 'Pokémon Hibou', 'de': 'Eule', 'es': 'Pokémon Búho', 'it': 'Pokémon Gufo', 'en': 'Owl Pokémon', 'ja': 'ふくろうポケモン', 'zh-Hans': '猫头鹰宝可梦'}}
	public class SpecieNoctowl : PokemonSpecie
	{
#nullable enable
		private static SpecieNoctowl? _instance = null;
#nullable restore
        public static SpecieNoctowl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoctowl();
                }
                return _instance;
            }
        }

		public SpecieNoctowl() : base(
			"Noctowl",
			100, // HPs
			50, 50, // Attack & Defense
			86, 96, // Special Attack & Defense
			70			
		) {}
	}


	//Noctowl Pokemon Class
	public class Noctowl : Pokemon
	{

		public Noctowl(string nickname, int level)
		: base(
				164,
				SpecieNoctowl.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Noctowl() : base(
			164,
			SpecieNoctowl.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}