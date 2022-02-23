using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Azurill Specie to store common natural stats of every {'abilities': ['thick-fat', 'huge-power', 'sap-sipper'], 'base_experience': 38, 'height': 2, 'id': 298, 'moves': ['slam', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'sing', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'waterfall', 'swift', 'bubble', 'splash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'whirlpool', 'uproar', 'hail', 'facade', 'helping-hand', 'knock-off', 'refresh', 'secret-power', 'camouflage', 'hyper-voice', 'fake-tears', 'tickle', 'muddy-water', 'bounce', 'covet', 'water-sport', 'water-pulse', 'natural-gift', 'copycat', 'captivate', 'soak', 'round', 'scald', 'work-up', 'confide'], 'name': 'azurill', 'stats': {'hp': 50, 'attack': 20, 'defense': 40, 'special-attack': 20, 'special-defense': 40, 'speed': 20}, 'types': ['normal', 'fairy'], 'weight': 20, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 150, 'color': 'blue', 'shape': 'legs', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ルリリ', 'roomaji': 'Ruriri', 'ko': '루리리', 'zh-Hant': '露力麗', 'fr': 'Azurill', 'de': 'Azurill', 'es': 'Azurill', 'it': 'Azurill', 'en': 'Azurill', 'ja': 'ルリリ', 'zh-Hans': '露力丽'}, 'genera': {'ja-Hrkt': 'みずたまポケモン', 'ko': '물방울포켓몬', 'zh-Hant': '水珠寶可夢', 'fr': 'Pokémon Point Polka', 'de': 'Gepunktet', 'es': 'Pokémon A Topos', 'it': 'Pokémon Pois', 'en': 'Polka Dot Pokémon', 'ja': 'みずたまポケモン', 'zh-Hans': '水珠宝可梦'}}
	public class SpecieAzurill : PokemonSpecie
	{
#nullable enable
		private static SpecieAzurill? _instance = null;
#nullable restore
        public static SpecieAzurill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzurill();
                }
                return _instance;
            }
        }

		public SpecieAzurill() : base(
			"Azurill",
			50, // HPs
			20, 40, // Attack & Defense
			20, 40, // Special Attack & Defense
			20			
		) {}
	}


	//Azurill Pokemon Class
	public class Azurill : Pokemon
	{

		public Azurill(string nickname, int level) : base(
			298,
			SpecieAzurill.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Fairy.Instance			
		) {}

		public Azurill() : base(
			298,
			SpecieAzurill.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
	}
}