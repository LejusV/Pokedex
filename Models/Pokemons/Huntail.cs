using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Huntail Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-veil'], 'base_experience': 170, 'height': 17, 'id': 367, 'moves': ['bind', 'body-slam', 'double-edge', 'bite', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'mimic', 'screech', 'double-team', 'waterfall', 'swift', 'rest', 'super-fang', 'substitute', 'snore', 'protect', 'scary-face', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'hidden-power', 'rain-dance', 'crunch', 'whirlpool', 'hail', 'facade', 'snatch', 'secret-power', 'dive', 'rock-tomb', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'sucker-punch', 'aqua-tail', 'giga-impact', 'ice-fang', 'captivate', 'coil', 'round', 'scald', 'confide', 'infestation'], 'name': 'huntail', 'stats': {'hp': 55, 'attack': 104, 'defense': 105, 'special-attack': 94, 'special-defense': 75, 'speed': 52}, 'types': ['water'], 'weight': 270, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'squiggle', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ハンテール', 'roomaji': 'Huntail', 'ko': '헌테일', 'zh-Hant': '獵斑魚', 'fr': 'Serpang', 'de': 'Aalabyss', 'es': 'Huntail', 'it': 'Huntail', 'en': 'Huntail', 'ja': 'ハンテール', 'zh-Hans': '猎斑鱼'}, 'genera': {'ja-Hrkt': 'しんかいポケモン', 'ko': '깊은바다포켓몬', 'zh-Hant': '深海寶可夢', 'fr': 'Pokémon Abysse', 'de': 'Tiefsee', 'es': 'Pokémon Abisal', 'it': 'Pokémon Abissi', 'en': 'Deep Sea Pokémon', 'ja': 'しんかいポケモン', 'zh-Hans': '深海宝可梦'}}
	public class SpecieHuntail : PokemonSpecie
	{
#nullable enable
		private static SpecieHuntail? _instance = null;
#nullable restore
        public static SpecieHuntail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHuntail();
                }
                return _instance;
            }
        }

		public SpecieHuntail() : base(
			"Huntail",
			55, // HPs
			104, 105, // Attack & Defense
			94, 75, // Special Attack & Defense
			52			
		) {}
	}


	//Huntail Pokemon Class
	public class Huntail : Pokemon
	{

		public Huntail(string nickname, int level)
		: base(
				367,
				SpecieHuntail.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Huntail() : base(
			367,
			SpecieHuntail.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}