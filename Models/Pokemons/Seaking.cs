using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seaking Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-veil', 'lightning-rod'], 'base_experience': 158, 'height': 13, 'id': 119, 'moves': ['horn-attack', 'fury-attack', 'horn-drill', 'take-down', 'double-edge', 'tail-whip', 'supersonic', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'peck', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'bide', 'waterfall', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'knock-off', 'secret-power', 'dive', 'signal-beam', 'bounce', 'water-sport', 'water-pulse', 'natural-gift', 'aqua-ring', 'poison-jab', 'aqua-tail', 'giga-impact', 'captivate', 'soak', 'round', 'scald', 'drill-run', 'confide', 'smart-strike'], 'name': 'seaking', 'stats': {'hp': 80, 'attack': 92, 'defense': 65, 'special-attack': 65, 'special-defense': 80, 'speed': 68}, 'types': ['water'], 'weight': 390, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'red', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'アズマオウ', 'roomaji': 'Azumao', 'ko': '왕콘치', 'zh-Hant': '金魚王', 'fr': 'Poissoroy', 'de': 'Golking', 'es': 'Seaking', 'it': 'Seaking', 'en': 'Seaking', 'ja': 'アズマオウ', 'zh-Hans': '金鱼王'}, 'genera': {'ja-Hrkt': 'きんぎょポケモン', 'ko': '금붕어포켓몬', 'zh-Hant': '金魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Goldfisch', 'es': 'Pokémon Pez Color', 'it': 'Pokémon Pescerosso', 'en': 'Goldfish Pokémon', 'ja': 'きんぎょポケモン', 'zh-Hans': '金鱼宝可梦'}}
	public class SpecieSeaking : PokemonSpecie
	{
#nullable enable
		private static SpecieSeaking? _instance = null;
#nullable restore
        public static SpecieSeaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeaking();
                }
                return _instance;
            }
        }

		public SpecieSeaking() : base(
			"Seaking",
			80, // HPs
			92, 65, // Attack & Defense
			65, 80, // Special Attack & Defense
			68			
		) {}
	}


	//Seaking Pokemon Class
	public class Seaking : Pokemon
	{

		public Seaking(string nickname, int level) : base(
			119,
			SpecieSeaking.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Seaking() : base(
			119,
			SpecieSeaking.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}