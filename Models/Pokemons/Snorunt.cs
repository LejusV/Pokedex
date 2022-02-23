using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snorunt Specie to store common natural stats of every {'abilities': ['inner-focus', 'ice-body', 'moody'], 'base_experience': 60, 'height': 7, 'id': 361, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'disable', 'ice-beam', 'blizzard', 'toxic', 'mimic', 'double-team', 'light-screen', 'bide', 'flash', 'rest', 'substitute', 'snore', 'spite', 'powder-snow', 'protect', 'spikes', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'crunch', 'shadow-ball', 'hail', 'facade', 'secret-power', 'weather-ball', 'fake-tears', 'block', 'water-pulse', 'natural-gift', 'switcheroo', 'avalanche', 'ice-shard', 'ice-fang', 'captivate', 'round', 'hex', 'frost-breath', 'confide'], 'name': 'snorunt', 'stats': {'hp': 50, 'attack': 50, 'defense': 50, 'special-attack': 50, 'special-defense': 50, 'speed': 50}, 'types': ['ice'], 'weight': 168, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'gray', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'mineral'], 'names': {'ja-Hrkt': 'ユキワラシ', 'roomaji': 'Yukiwarashi', 'ko': '눈꼬마', 'zh-Hant': '雪童子', 'fr': 'Stalgamin', 'de': 'Schneppke', 'es': 'Snorunt', 'it': 'Snorunt', 'en': 'Snorunt', 'ja': 'ユキワラシ', 'zh-Hans': '雪童子'}, 'genera': {'ja-Hrkt': 'ゆきかさポケモン', 'ko': '눈우산포켓몬', 'zh-Hant': '雪笠寶可夢', 'fr': 'Pokémon Capuche', 'de': 'Schneehut', 'es': 'Pokémon Gorro Nieve', 'it': 'Pokémon Cappelneve', 'en': 'Snow Hat Pokémon', 'ja': 'ゆきかさポケモン', 'zh-Hans': '雪笠宝可梦'}}
	public class SpecieSnorunt : PokemonSpecie
	{
#nullable enable
		private static SpecieSnorunt? _instance = null;
#nullable restore
        public static SpecieSnorunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnorunt();
                }
                return _instance;
            }
        }

		public SpecieSnorunt() : base(
			"Snorunt",
			50, // HPs
			50, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			50			
		) {}
	}


	//Snorunt Pokemon Class
	public class Snorunt : Pokemon
	{

		public Snorunt(string nickname, int level) : base(
			361,
			SpecieSnorunt.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance			
		) {}

		public Snorunt() : base(
			361,
			SpecieSnorunt.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}