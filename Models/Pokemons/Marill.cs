using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marill Specie to store common natural stats of every {'abilities': ['thick-fat', 'huge-power', 'sap-sipper'], 'base_experience': 88, 'height': 4, 'id': 183, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'seismic-toss', 'strength', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'waterfall', 'swift', 'amnesia', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'foresight', 'perish-song', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'present', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'future-sight', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'refresh', 'secret-power', 'dive', 'camouflage', 'hyper-voice', 'muddy-water', 'bounce', 'covet', 'water-sport', 'water-pulse', 'natural-gift', 'fling', 'aqua-ring', 'aqua-tail', 'captivate', 'grass-knot', 'aqua-jet', 'round', 'scald', 'work-up', 'play-rough', 'confide', 'power-up-punch'], 'name': 'marill', 'stats': {'hp': 70, 'attack': 20, 'defense': 50, 'special-attack': 20, 'special-defense': 50, 'speed': 40}, 'types': ['water', 'fairy'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['water1', 'fairy'], 'names': {'ja-Hrkt': 'マリル', 'roomaji': 'Maril', 'ko': '마릴', 'zh-Hant': '瑪力露', 'fr': 'Marill', 'de': 'Marill', 'es': 'Marill', 'it': 'Marill', 'en': 'Marill', 'ja': 'マリル', 'zh-Hans': '玛力露'}, 'genera': {'ja-Hrkt': 'みずねずみポケモン', 'ko': '물쥐포켓몬', 'zh-Hant': '水鼠寶可夢', 'fr': 'Pokémon Aquasouris', 'de': 'Aquamaus', 'es': 'Pokémon Ratón Agua', 'it': 'Pokémon Acquatopo', 'en': 'Aqua Mouse Pokémon', 'ja': 'みずねずみポケモン', 'zh-Hans': '水鼠宝可梦'}}
	public class SpecieMarill : PokemonSpecie
	{
#nullable enable
		private static SpecieMarill? _instance = null;
#nullable restore
        public static SpecieMarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarill();
                }
                return _instance;
            }
        }

		public SpecieMarill() : base(
			"Marill",
			70, // HPs
			20, 50, // Attack & Defense
			20, 50, // Special Attack & Defense
			40			
		) {}
	}


	//Marill Pokemon Class
	public class Marill : Pokemon
	{

		public Marill(string nickname, int level)
		: base(
				183,
				SpecieMarill.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Marill() : base(
			183,
			SpecieMarill.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
	}
}