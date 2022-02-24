using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fennekin Specie to store common natural stats of every {'abilities': ['blaze', 'magician'], 'base_experience': 61, 'height': 4, 'id': 653, 'moves': ['scratch', 'cut', 'tail-whip', 'ember', 'flamethrower', 'psybeam', 'solar-beam', 'fire-spin', 'toxic', 'psychic', 'hypnosis', 'double-team', 'light-screen', 'fire-blast', 'dream-eater', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'heat-wave', 'will-o-wisp', 'facade', 'wish', 'magic-coat', 'secret-power', 'overheat', 'howl', 'covet', 'embargo', 'lucky-chant', 'grass-knot', 'psyshock', 'magic-room', 'flame-charge', 'foul-play', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'confide', 'power-up-punch', 'psychic-terrain'], 'name': 'fennekin', 'stats': {'hp': 40, 'attack': 45, 'defense': 40, 'special-attack': 62, 'special-defense': 60, 'speed': 60}, 'types': ['fire'], 'weight': 94, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'フォッコ', 'ko': '푸호꼬', 'zh-Hant': '火狐狸', 'fr': 'Feunnec', 'de': 'Fynx', 'es': 'Fennekin', 'it': 'Fennekin', 'en': 'Fennekin', 'ja': 'フォッコ', 'zh-Hans': '火狐狸'}, 'genera': {'ja-Hrkt': 'キツネポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'キツネポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieFennekin : PokemonSpecie
	{
#nullable enable
		private static SpecieFennekin? _instance = null;
#nullable restore
        public static SpecieFennekin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFennekin();
                }
                return _instance;
            }
        }

		public SpecieFennekin() : base(
			"Fennekin",
			40, // HPs
			45, 40, // Attack & Defense
			62, 60, // Special Attack & Defense
			60			
		) {}
	}


	//Fennekin Pokemon Class
	public class Fennekin : Pokemon
	{

		public Fennekin(string nickname, int level)
		: base(
				653,
				SpecieFennekin.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Fennekin() : base(
			653,
			SpecieFennekin.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}