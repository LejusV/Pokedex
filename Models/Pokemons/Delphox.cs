using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Delphox Specie to store common natural stats of every {'abilities': ['blaze', 'magician'], 'base_experience': 240, 'height': 15, 'id': 655, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'cut', 'tail-whip', 'ember', 'flamethrower', 'psybeam', 'hyper-beam', 'low-kick', 'solar-beam', 'fire-spin', 'toxic', 'psychic', 'double-team', 'light-screen', 'fire-blast', 'dream-eater', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'heat-wave', 'will-o-wisp', 'facade', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'snatch', 'secret-power', 'blast-burn', 'overheat', 'signal-beam', 'howl', 'covet', 'calm-mind', 'shock-wave', 'embargo', 'lucky-chant', 'switcheroo', 'giga-impact', 'zen-headbutt', 'trick-room', 'grass-knot', 'wonder-room', 'psyshock', 'magic-room', 'flame-charge', 'foul-play', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'confide', 'mystical-fire', 'dazzling-gleam', 'power-up-punch'], 'name': 'delphox', 'stats': {'hp': 75, 'attack': 69, 'defense': 72, 'special-attack': 114, 'special-defense': 100, 'speed': 104}, 'types': ['fire', 'psychic'], 'weight': 390, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マフォクシー', 'ko': '마폭시', 'zh-Hant': '妖火紅狐', 'fr': 'Goupelin', 'de': 'Fennexis', 'es': 'Delphox', 'it': 'Delphox', 'en': 'Delphox', 'ja': 'マフォクシー', 'zh-Hans': '妖火红狐'}, 'genera': {'ja-Hrkt': 'キツネポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'キツネポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieDelphox : PokemonSpecie
	{
#nullable enable
		private static SpecieDelphox? _instance = null;
#nullable restore
        public static SpecieDelphox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelphox();
                }
                return _instance;
            }
        }

		public SpecieDelphox() : base(
			"Delphox",
			75, // HPs
			69, 72, // Attack & Defense
			114, 100, // Special Attack & Defense
			104			
		) {}
	}


	//Delphox Pokemon Class
	public class Delphox : Pokemon
	{

		public Delphox(string nickname, int level)
		: base(
				655,
				SpecieDelphox.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Delphox(int level)
		: base(
				655,
				SpecieDelphox.Instance, // Pokemon Specie
				"Delphox", level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Delphox() : base(
			655,
			SpecieDelphox.Instance, // Pokemon Specie
			Fire.Instance, Psychic.Instance			
		) {}
	}
}