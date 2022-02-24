using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Togepi Specie to store common natural stats of every {'abilities': ['hustle', 'serene-grace', 'super-luck'], 'base_experience': 49, 'height': 3, 'id': 175, 'moves': ['mega-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'growl', 'flamethrower', 'peck', 'counter', 'seismic-toss', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'metronome', 'mirror-move', 'fire-blast', 'swift', 'soft-boiled', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sweet-kiss', 'mud-slap', 'zap-cannon', 'foresight', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'safeguard', 'baton-pass', 'encore', 'morning-sun', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'rock-smash', 'uproar', 'facade', 'follow-me', 'trick', 'wish', 'magic-coat', 'yawn', 'endeavor', 'secret-power', 'hyper-voice', 'signal-beam', 'extrasensory', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'psycho-shift', 'lucky-chant', 'last-resort', 'nasty-plot', 'zen-headbutt', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'stored-power', 'incinerate', 'bestow', 'work-up', 'confide', 'dazzling-gleam'], 'name': 'togepi', 'stats': {'hp': 35, 'attack': 20, 'defense': 65, 'special-attack': 40, 'special-defense': 65, 'speed': 20}, 'types': ['fairy'], 'weight': 15, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 1, 'capture_rate': 190, 'color': 'white', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'トゲピー', 'roomaji': 'Togepy', 'ko': '토게피', 'zh-Hant': '波克比', 'fr': 'Togepi', 'de': 'Togepi', 'es': 'Togepi', 'it': 'Togepi', 'en': 'Togepi', 'ja': 'トゲピー', 'zh-Hans': '波克比'}, 'genera': {'ja-Hrkt': 'はりたまポケモン', 'ko': '바늘알포켓몬', 'zh-Hant': '針球寶可夢', 'fr': 'Pokémon Balle Pic', 'de': 'Zackenball', 'es': 'Pokémon Bolaclavos', 'it': 'Pokémon Pallapunte', 'en': 'Spike Ball Pokémon', 'ja': 'はりたまポケモン', 'zh-Hans': '针球宝可梦'}}
	public class SpecieTogepi : PokemonSpecie
	{
#nullable enable
		private static SpecieTogepi? _instance = null;
#nullable restore
        public static SpecieTogepi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogepi();
                }
                return _instance;
            }
        }

		public SpecieTogepi() : base(
			"Togepi",
			35, // HPs
			20, 65, // Attack & Defense
			40, 65, // Special Attack & Defense
			20			
		) {}
	}


	//Togepi Pokemon Class
	public class Togepi : Pokemon
	{

		public Togepi(string nickname, int level)
		: base(
				175,
				SpecieTogepi.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togepi() : base(
			175,
			SpecieTogepi.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}