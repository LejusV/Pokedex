using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Braixen Specie to store common natural stats of every {'abilities': ['blaze', 'magician'], 'base_experience': 143, 'height': 10, 'id': 654, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'cut', 'tail-whip', 'ember', 'flamethrower', 'psybeam', 'low-kick', 'solar-beam', 'fire-spin', 'toxic', 'psychic', 'double-team', 'light-screen', 'fire-blast', 'dream-eater', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'heat-wave', 'will-o-wisp', 'facade', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'snatch', 'secret-power', 'overheat', 'howl', 'covet', 'shock-wave', 'embargo', 'lucky-chant', 'zen-headbutt', 'grass-knot', 'wonder-room', 'psyshock', 'magic-room', 'flame-charge', 'foul-play', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'braixen', 'stats': {'hp': 59, 'attack': 59, 'defense': 58, 'special-attack': 90, 'special-defense': 70, 'speed': 73}, 'types': ['fire'], 'weight': 145, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'テールナー', 'ko': '테르나', 'zh-Hant': '長尾火狐', 'fr': 'Roussil', 'de': 'Rutena', 'es': 'Braixen', 'it': 'Braixen', 'en': 'Braixen', 'ja': 'テールナー', 'zh-Hans': '长尾火狐'}, 'genera': {'ja-Hrkt': 'キツネポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'キツネポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieBraixen : PokemonSpecie
	{
#nullable enable
		private static SpecieBraixen? _instance = null;
#nullable restore
        public static SpecieBraixen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBraixen();
                }
                return _instance;
            }
        }

		public SpecieBraixen() : base(
			"Braixen",
			59, // HPs
			59, 58, // Attack & Defense
			90, 70, // Special Attack & Defense
			73			
		) {}
	}


	//Braixen Pokemon Class
	public class Braixen : Pokemon
	{

		public Braixen(string nickname, int level)
		: base(
				654,
				SpecieBraixen.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Braixen(int level)
		: base(
				654,
				SpecieBraixen.Instance, // Pokemon Specie
				"Braixen", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Braixen() : base(
			654,
			SpecieBraixen.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}