using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meganium Specie to store common natural stats of every {'abilities': ['overgrow', 'leaf-guard'], 'base_experience': 236, 'height': 18, 'id': 154, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'growl', 'hyper-beam', 'counter', 'strength', 'razor-leaf', 'solar-beam', 'poison-powder', 'petal-dance', 'earthquake', 'toxic', 'mimic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'outrage', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'nature-power', 'magic-coat', 'secret-power', 'aromatherapy', 'bullet-seed', 'frenzy-plant', 'magical-leaf', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'rock-climb', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'grass-pledge', 'bulldoze', 'dragon-tail', 'work-up', 'petal-blizzard', 'confide'], 'name': 'meganium', 'stats': {'hp': 80, 'attack': 82, 'defense': 100, 'special-attack': 83, 'special-defense': 100, 'speed': 80}, 'types': ['grass'], 'weight': 1005, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'メガニウム', 'roomaji': 'Meganium', 'ko': '메가니움', 'zh-Hant': '大竺葵', 'fr': 'Méganium', 'de': 'Meganie', 'es': 'Meganium', 'it': 'Meganium', 'en': 'Meganium', 'ja': 'メガニウム', 'zh-Hans': '大竺葵'}, 'genera': {'ja-Hrkt': 'ハーブポケモン', 'ko': '허브포켓몬', 'zh-Hant': '芳草寶可夢', 'fr': 'Pokémon Herbe', 'de': 'Kräuter', 'es': 'Pokémon Hierba', 'it': 'Pokémon Erbe', 'en': 'Herb Pokémon', 'ja': 'ハーブポケモン', 'zh-Hans': '芳草宝可梦'}}
	public class SpecieMeganium : PokemonSpecie
	{
#nullable enable
		private static SpecieMeganium? _instance = null;
#nullable restore
        public static SpecieMeganium Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeganium();
                }
                return _instance;
            }
        }

		public SpecieMeganium() : base(
			"Meganium",
			80, // HPs
			82, 100, // Attack & Defense
			83, 100, // Special Attack & Defense
			80			
		) {}
	}


	//Meganium Pokemon Class
	public class Meganium : Pokemon
	{

		public Meganium(string nickname, int level) : base(
			154,
			SpecieMeganium.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Meganium() : base(
			154,
			SpecieMeganium.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}