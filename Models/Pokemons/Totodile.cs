using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Totodile Specie to store common natural stats of every {'abilities': ['torrent', 'sheer-force'], 'base_experience': 63, 'height': 6, 'id': 158, 'moves': ['mega-punch', 'ice-punch', 'scratch', 'razor-wind', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'waterfall', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'flail', 'spite', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'whirlpool', 'uproar', 'hail', 'flatter', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'dive', 'mud-sport', 'fake-tears', 'rock-tomb', 'aerial-ace', 'block', 'dragon-claw', 'water-sport', 'dragon-dance', 'water-pulse', 'natural-gift', 'fling', 'aqua-tail', 'shadow-claw', 'ice-fang', 'captivate', 'aqua-jet', 'hone-claws', 'round', 'chip-away', 'scald', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'totodile', 'stats': {'hp': 50, 'attack': 65, 'defense': 64, 'special-attack': 44, 'special-defense': 48, 'speed': 43}, 'types': ['water'], 'weight': 95, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ワニノコ', 'roomaji': 'Waninoko', 'ko': '리아코', 'zh-Hant': '小鋸鱷', 'fr': 'Kaiminus', 'de': 'Karnimani', 'es': 'Totodile', 'it': 'Totodile', 'en': 'Totodile', 'ja': 'ワニノコ', 'zh-Hans': '小锯鳄'}, 'genera': {'ja-Hrkt': 'おおあごポケモン', 'ko': '큰턱포켓몬', 'zh-Hant': '大顎寶可夢', 'fr': 'Pokémon Mâchoire', 'de': 'Großmaul', 'es': 'Pokémon Fauces', 'it': 'Pokémon Mascellone', 'en': 'Big Jaw Pokémon', 'ja': 'おおあごポケモン', 'zh-Hans': '大颚宝可梦'}}
	public class SpecieTotodile : PokemonSpecie
	{
#nullable enable
		private static SpecieTotodile? _instance = null;
#nullable restore
        public static SpecieTotodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTotodile();
                }
                return _instance;
            }
        }

		public SpecieTotodile() : base(
			"Totodile",
			50, // HPs
			65, 64, // Attack & Defense
			44, 48, // Special Attack & Defense
			43			
		) {}
	}


	//Totodile Pokemon Class
	public class Totodile : Pokemon
	{

		public Totodile(string nickname, int level) : base(
			158,
			SpecieTotodile.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Totodile() : base(
			158,
			SpecieTotodile.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}