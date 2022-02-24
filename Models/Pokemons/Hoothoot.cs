using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hoothoot Specie to store common natural stats of every {'abilities': ['insomnia', 'keen-eye', 'tinted-lens'], 'base_experience': 52, 'height': 7, 'id': 163, 'moves': ['wing-attack', 'whirlwind', 'fly', 'tackle', 'take-down', 'double-edge', 'growl', 'supersonic', 'peck', 'toxic', 'confusion', 'psychic', 'hypnosis', 'agility', 'night-shade', 'mimic', 'double-team', 'reflect', 'mirror-move', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'feint-attack', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'heat-wave', 'facade', 'magic-coat', 'recycle', 'secret-power', 'feather-dance', 'hyper-voice', 'air-cutter', 'silver-wind', 'extrasensory', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'psycho-shift', 'air-slash', 'zen-headbutt', 'defog', 'captivate', 'ominous-wind', 'synchronoise', 'round', 'echoed-voice', 'work-up', 'hurricane', 'moonblast', 'confide'], 'name': 'hoothoot', 'stats': {'hp': 60, 'attack': 30, 'defense': 30, 'special-attack': 36, 'special-defense': 56, 'speed': 50}, 'types': ['normal', 'flying'], 'weight': 212, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ホーホー', 'roomaji': 'Hoho', 'ko': '부우부', 'zh-Hant': '咕咕', 'fr': 'Hoothoot', 'de': 'Hoothoot', 'es': 'Hoothoot', 'it': 'Hoothoot', 'en': 'Hoothoot', 'ja': 'ホーホー', 'zh-Hans': '咕咕'}, 'genera': {'ja-Hrkt': 'ふくろうポケモン', 'ko': '부엉이포켓몬', 'zh-Hant': '貓頭鷹寶可夢', 'fr': 'Pokémon Hibou', 'de': 'Eule', 'es': 'Pokémon Búho', 'it': 'Pokémon Gufo', 'en': 'Owl Pokémon', 'ja': 'ふくろうポケモン', 'zh-Hans': '猫头鹰宝可梦'}}
	public class SpecieHoothoot : PokemonSpecie
	{
#nullable enable
		private static SpecieHoothoot? _instance = null;
#nullable restore
        public static SpecieHoothoot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoothoot();
                }
                return _instance;
            }
        }

		public SpecieHoothoot() : base(
			"Hoothoot",
			60, // HPs
			30, 30, // Attack & Defense
			36, 56, // Special Attack & Defense
			50			
		) {}
	}


	//Hoothoot Pokemon Class
	public class Hoothoot : Pokemon
	{

		public Hoothoot(string nickname, int level)
		: base(
				163,
				SpecieHoothoot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hoothoot(int level)
		: base(
				163,
				SpecieHoothoot.Instance, // Pokemon Specie
				"Hoothoot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hoothoot() : base(
			163,
			SpecieHoothoot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}