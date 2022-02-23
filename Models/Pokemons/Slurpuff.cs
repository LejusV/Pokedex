using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slurpuff Specie to store common natural stats of every {'abilities': ['sweet-veil', 'unburden'], 'base_experience': 168, 'height': 8, 'id': 685, 'moves': ['tackle', 'flamethrower', 'surf', 'hyper-beam', 'thunderbolt', 'toxic', 'psychic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'cotton-spore', 'protect', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'facade', 'helping-hand', 'wish', 'magic-coat', 'endeavor', 'secret-power', 'aromatherapy', 'fake-tears', 'covet', 'calm-mind', 'gastro-acid', 'drain-punch', 'energy-ball', 'giga-impact', 'after-you', 'round', 'cotton-guard', 'draining-kiss', 'play-rough', 'fairy-wind', 'play-nice', 'confide', 'dazzling-gleam'], 'name': 'slurpuff', 'stats': {'hp': 82, 'attack': 80, 'defense': 86, 'special-attack': 85, 'special-defense': 75, 'speed': 72}, 'types': ['fairy'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 140, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ペロリーム', 'ko': '나루림', 'zh-Hant': '胖甜妮', 'fr': 'Cupcanaille', 'de': 'Sabbaione', 'es': 'Slurpuff', 'it': 'Slurpuff', 'en': 'Slurpuff', 'ja': 'ペロリーム', 'zh-Hans': '胖甜妮'}, 'genera': {'ja-Hrkt': 'ホイップポケモン', 'ko': '휩포켓몬', 'zh-Hant': '泡沫奶油寶可夢', 'fr': 'Pokémon Mousseline', 'de': 'Schlagsahne', 'es': 'Pokémon Nata', 'it': 'Pokémon Panna', 'en': 'Meringue Pokémon', 'ja': 'ホイップポケモン', 'zh-Hans': '泡沫奶油宝可梦'}}
	public class SpecieSlurpuff : PokemonSpecie
	{
#nullable enable
		private static SpecieSlurpuff? _instance = null;
#nullable restore
        public static SpecieSlurpuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlurpuff();
                }
                return _instance;
            }
        }

		public SpecieSlurpuff() : base(
			"Slurpuff",
			82, // HPs
			80, 86, // Attack & Defense
			85, 75, // Special Attack & Defense
			72			
		) {}
	}


	//Slurpuff Pokemon Class
	public class Slurpuff : Pokemon
	{

		public Slurpuff(string nickname, int level) : base(
			685,
			SpecieSlurpuff.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Slurpuff() : base(
			685,
			SpecieSlurpuff.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}