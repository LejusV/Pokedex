using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Azumarill Specie to store common natural stats of every {'abilities': ['thick-fat', 'huge-power', 'sap-sipper'], 'base_experience': 189, 'height': 8, 'id': 184, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'seismic-toss', 'strength', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'waterfall', 'swift', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'dive', 'hyper-voice', 'bounce', 'covet', 'water-sport', 'water-pulse', 'natural-gift', 'fling', 'aqua-ring', 'aqua-tail', 'focus-blast', 'giga-impact', 'captivate', 'grass-knot', 'round', 'scald', 'bulldoze', 'work-up', 'play-rough', 'confide', 'power-up-punch'], 'name': 'azumarill', 'stats': {'hp': 100, 'attack': 50, 'defense': 80, 'special-attack': 60, 'special-defense': 80, 'speed': 50}, 'types': ['water', 'fairy'], 'weight': 285, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['water1', 'fairy'], 'names': {'ja-Hrkt': 'マリルリ', 'roomaji': 'Marilli', 'ko': '마릴리', 'zh-Hant': '瑪力露麗', 'fr': 'Azumarill', 'de': 'Azumarill', 'es': 'Azumarill', 'it': 'Azumarill', 'en': 'Azumarill', 'ja': 'マリルリ', 'zh-Hans': '玛力露丽'}, 'genera': {'ja-Hrkt': 'みずうさぎポケモン', 'ko': '물토끼포켓몬', 'zh-Hant': '水兔寶可夢', 'fr': 'Pokémon Aqualapin', 'de': 'Aquahase', 'es': 'Pokémon Conejo Agua', 'it': 'Pokémon Acquniglio', 'en': 'Aqua Rabbit Pokémon', 'ja': 'みずうさぎポケモン', 'zh-Hans': '水兔宝可梦'}}
	public class SpecieAzumarill : PokemonSpecie
	{
#nullable enable
		private static SpecieAzumarill? _instance = null;
#nullable restore
        public static SpecieAzumarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzumarill();
                }
                return _instance;
            }
        }

		public SpecieAzumarill() : base(
			"Azumarill",
			100, // HPs
			50, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			50			
		) {}
	}


	//Azumarill Pokemon Class
	public class Azumarill : Pokemon
	{

		public Azumarill(string nickname, int level) : base(
			184,
			SpecieAzumarill.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Fairy.Instance			
		) {}

		public Azumarill() : base(
			184,
			SpecieAzumarill.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
	}
}