using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Naganadel Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 243, 'height': 36, 'id': 804, 'moves': ['fly', 'fury-attack', 'growl', 'acid', 'flamethrower', 'hyper-beam', 'peck', 'thunderbolt', 'toxic', 'double-team', 'fire-blast', 'leech-life', 'rest', 'substitute', 'thief', 'protect', 'sludge-bomb', 'charm', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'facade', 'helping-hand', 'air-cutter', 'aerial-ace', 'dragon-claw', 'u-turn', 'poison-jab', 'dark-pulse', 'air-slash', 'x-scissor', 'dragon-pulse', 'nasty-plot', 'shadow-claw', 'draco-meteor', 'venoshock', 'sludge-wave', 'round', 'echoed-voice', 'sky-drop', 'acrobatics', 'dragon-tail', 'snarl', 'fell-stinger', 'confide', 'venom-drench', 'smart-strike'], 'name': 'naganadel', 'stats': {'hp': 73, 'attack': 73, 'defense': 73, 'special-attack': 127, 'special-defense': 73, 'speed': 121}, 'types': ['poison', 'dragon'], 'weight': 1500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'アーゴヨン', 'ko': '아고용', 'zh-Hant': '四顎針龍', 'fr': 'Mandrillon', 'de': 'Agoyon', 'es': 'Naganadel', 'it': 'Naganadel', 'en': 'Naganadel', 'ja': 'アーゴヨン', 'zh-Hans': '四颚针龙'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpecieNaganadel : PokemonSpecie
	{
#nullable enable
		private static SpecieNaganadel? _instance = null;
#nullable restore
        public static SpecieNaganadel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNaganadel();
                }
                return _instance;
            }
        }

		public SpecieNaganadel() : base(
			"Naganadel",
			73, // HPs
			73, 73, // Attack & Defense
			127, 73, // Special Attack & Defense
			121			
		) {}
	}


	//Naganadel Pokemon Class
	public class Naganadel : Pokemon
	{

		public Naganadel(string nickname, int level)
		: base(
				804,
				SpecieNaganadel.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Naganadel() : base(
			804,
			SpecieNaganadel.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
	}
}