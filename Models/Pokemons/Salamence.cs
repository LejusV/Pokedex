using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Salamence Specie to store common natural stats of every {'abilities': ['intimidate', 'moxie'], 'base_experience': 270, 'height': 15, 'id': 373, 'moves': ['cut', 'fly', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'fire-blast', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'endure', 'rollout', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'heat-wave', 'facade', 'brick-break', 'secret-power', 'hyper-voice', 'air-cutter', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'roost', 'natural-gift', 'tailwind', 'aqua-tail', 'dragon-pulse', 'giga-impact', 'shadow-claw', 'thunder-fang', 'fire-fang', 'zen-headbutt', 'defog', 'draco-meteor', 'stone-edge', 'captivate', 'ominous-wind', 'hone-claws', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'salamence', 'stats': {'hp': 95, 'attack': 135, 'defense': 80, 'special-attack': 110, 'special-defense': 80, 'speed': 100}, 'types': ['dragon', 'flying'], 'weight': 1026, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ボーマンダ', 'roomaji': 'Bohmander', 'ko': '보만다', 'zh-Hant': '暴飛龍', 'fr': 'Drattak', 'de': 'Brutalanda', 'es': 'Salamence', 'it': 'Salamence', 'en': 'Salamence', 'ja': 'ボーマンダ', 'zh-Hans': '暴飞龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieSalamence : PokemonSpecie
	{
#nullable enable
		private static SpecieSalamence? _instance = null;
#nullable restore
        public static SpecieSalamence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalamence();
                }
                return _instance;
            }
        }

		public SpecieSalamence() : base(
			"Salamence",
			95, // HPs
			135, 80, // Attack & Defense
			110, 80, // Special Attack & Defense
			100			
		) {}
	}


	//Salamence Pokemon Class
	public class Salamence : Pokemon
	{

		public Salamence(string nickname, int level)
		: base(
				373,
				SpecieSalamence.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Salamence() : base(
			373,
			SpecieSalamence.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
	}
}