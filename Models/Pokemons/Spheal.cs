using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spheal Specie to store common natural stats of every {'abilities': ['thick-fat', 'ice-body', 'oblivious'], 'base_experience': 58, 'height': 8, 'id': 363, 'moves': ['headbutt', 'body-slam', 'double-edge', 'growl', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'aurora-beam', 'strength', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'defense-curl', 'waterfall', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'curse', 'powder-snow', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'yawn', 'secret-power', 'dive', 'ice-ball', 'rock-tomb', 'signal-beam', 'sheer-cold', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'aqua-ring', 'aqua-tail', 'captivate', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'confide'], 'name': 'spheal', 'stats': {'hp': 70, 'attack': 40, 'defense': 50, 'special-attack': 55, 'special-defense': 50, 'speed': 25}, 'types': ['ice', 'water'], 'weight': 395, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'タマザラシ', 'roomaji': 'Tamazarashi', 'ko': '대굴레오', 'zh-Hant': '海豹球', 'fr': 'Obalie', 'de': 'Seemops', 'es': 'Spheal', 'it': 'Spheal', 'en': 'Spheal', 'ja': 'タマザラシ', 'zh-Hans': '海豹球'}, 'genera': {'ja-Hrkt': 'てたたきポケモン', 'ko': '손뼉포켓몬', 'zh-Hant': '拍手寶可夢', 'fr': 'Pokémon Clap Clap', 'de': 'Applaus', 'es': 'Pokémon Aplauso', 'it': 'Pokémon Rotolante', 'en': 'Clap Pokémon', 'ja': 'てたたきポケモン', 'zh-Hans': '拍手宝可梦'}}
	public class SpecieSpheal : PokemonSpecie
	{
#nullable enable
		private static SpecieSpheal? _instance = null;
#nullable restore
        public static SpecieSpheal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpheal();
                }
                return _instance;
            }
        }

		public SpecieSpheal() : base(
			"Spheal",
			70, // HPs
			40, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			25			
		) {}
	}


	//Spheal Pokemon Class
	public class Spheal : Pokemon
	{

		public Spheal(string nickname, int level)
		: base(
				363,
				SpecieSpheal.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spheal() : base(
			363,
			SpecieSpheal.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
	}
}