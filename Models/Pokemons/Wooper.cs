using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wooper Specie to store common natural stats of every {'abilities': ['damp', 'water-absorb', 'unaware'], 'base_experience': 42, 'height': 4, 'id': 194, 'moves': ['ice-punch', 'slam', 'double-kick', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'mist', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'counter', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'recover', 'defense-curl', 'haze', 'waterfall', 'amnesia', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'yawn', 'secret-power', 'dive', 'mud-sport', 'muddy-water', 'mud-shot', 'water-pulse', 'natural-gift', 'guard-swap', 'aqua-tail', 'earth-power', 'mud-bomb', 'captivate', 'sludge-wave', 'acid-spray', 'after-you', 'round', 'scald', 'bulldoze', 'confide', 'eerie-impulse', 'infestation', 'power-up-punch'], 'name': 'wooper', 'stats': {'hp': 55, 'attack': 45, 'defense': 45, 'special-attack': 25, 'special-defense': 25, 'speed': 15}, 'types': ['water', 'ground'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'legs', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ウパー', 'roomaji': 'Upah', 'ko': '우파', 'zh-Hant': '烏波', 'fr': 'Axoloto', 'de': 'Felino', 'es': 'Wooper', 'it': 'Wooper', 'en': 'Wooper', 'ja': 'ウパー', 'zh-Hans': '乌波'}, 'genera': {'ja-Hrkt': 'みずうおポケモン', 'ko': '수어포켓몬', 'zh-Hant': '水魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Fisch', 'es': 'Pokémon Pez Agua', 'it': 'Pokémon Acquapesce', 'en': 'Water Fish Pokémon', 'ja': 'みずうおポケモン', 'zh-Hans': '水鱼宝可梦'}}
	public class SpecieWooper : PokemonSpecie
	{
#nullable enable
		private static SpecieWooper? _instance = null;
#nullable restore
        public static SpecieWooper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWooper();
                }
                return _instance;
            }
        }

		public SpecieWooper() : base(
			"Wooper",
			55, // HPs
			45, 45, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
	}


	//Wooper Pokemon Class
	public class Wooper : Pokemon
	{

		public Wooper(string nickname, int level)
		: base(
				194,
				SpecieWooper.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wooper() : base(
			194,
			SpecieWooper.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}