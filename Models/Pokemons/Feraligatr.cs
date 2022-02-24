using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Feraligatr Specie to store common natural stats of every {'abilities': ['torrent', 'sheer-force'], 'base_experience': 239, 'height': 23, 'id': 160, 'moves': ['mega-punch', 'ice-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'waterfall', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'flail', 'spite', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'detect', 'outrage', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'dive', 'hydro-cannon', 'rock-tomb', 'aerial-ace', 'block', 'dragon-claw', 'water-pulse', 'natural-gift', 'fling', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'avalanche', 'shadow-claw', 'ice-fang', 'rock-climb', 'captivate', 'hone-claws', 'round', 'chip-away', 'scald', 'water-pledge', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'power-up-punch'], 'name': 'feraligatr', 'stats': {'hp': 85, 'attack': 105, 'defense': 100, 'special-attack': 79, 'special-defense': 83, 'speed': 78}, 'types': ['water'], 'weight': 888, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'オーダイル', 'roomaji': 'Ordile', 'ko': '장크로다일', 'zh-Hant': '大力鱷', 'fr': 'Aligatueur', 'de': 'Impergator', 'es': 'Feraligatr', 'it': 'Feraligatr', 'en': 'Feraligatr', 'ja': 'オーダイル', 'zh-Hans': '大力鳄'}, 'genera': {'ja-Hrkt': 'おおあごポケモン', 'ko': '큰턱포켓몬', 'zh-Hant': '大顎寶可夢', 'fr': 'Pokémon Mâchoire', 'de': 'Großmaul', 'es': 'Pokémon Fauces', 'it': 'Pokémon Mascellone', 'en': 'Big Jaw Pokémon', 'ja': 'おおあごポケモン', 'zh-Hans': '大颚宝可梦'}}
	public class SpecieFeraligatr : PokemonSpecie
	{
#nullable enable
		private static SpecieFeraligatr? _instance = null;
#nullable restore
        public static SpecieFeraligatr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFeraligatr();
                }
                return _instance;
            }
        }

		public SpecieFeraligatr() : base(
			"Feraligatr",
			85, // HPs
			105, 100, // Attack & Defense
			79, 83, // Special Attack & Defense
			78			
		) {}
	}


	//Feraligatr Pokemon Class
	public class Feraligatr : Pokemon
	{

		public Feraligatr(string nickname, int level)
		: base(
				160,
				SpecieFeraligatr.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Feraligatr(int level)
		: base(
				160,
				SpecieFeraligatr.Instance, // Pokemon Specie
				"Feraligatr", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Feraligatr() : base(
			160,
			SpecieFeraligatr.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}