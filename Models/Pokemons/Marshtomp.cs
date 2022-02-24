using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marshtomp Specie to store common natural stats of every {'abilities': ['torrent', 'damp'], 'base_experience': 142, 'height': 7, 'id': 259, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'bide', 'waterfall', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'muddy-water', 'mud-shot', 'water-pulse', 'natural-gift', 'fling', 'aqua-tail', 'earth-power', 'mud-bomb', 'captivate', 'stealth-rock', 'sludge-wave', 'round', 'echoed-voice', 'scald', 'water-pledge', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'marshtomp', 'stats': {'hp': 70, 'attack': 85, 'defense': 70, 'special-attack': 60, 'special-defense': 70, 'speed': 50}, 'types': ['water', 'ground'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ヌマクロー', 'roomaji': 'Numacraw', 'ko': '늪짱이', 'zh-Hant': '沼躍魚', 'fr': 'Flobio', 'de': 'Moorabbel', 'es': 'Marshtomp', 'it': 'Marshtomp', 'en': 'Marshtomp', 'ja': 'ヌマクロー', 'zh-Hans': '沼躍鱼'}, 'genera': {'ja-Hrkt': 'ぬまうおポケモン', 'ko': '늪물고기포켓몬', 'zh-Hant': '沼魚寶可夢', 'fr': 'Pokémon Poissonboue', 'de': 'Lehmhüpfer', 'es': 'Pokémon Pez Lodo', 'it': 'Pokémon Fango Pesce', 'en': 'Mud Fish Pokémon', 'ja': 'ぬまうおポケモン', 'zh-Hans': '沼鱼宝可梦'}}
	public class SpecieMarshtomp : PokemonSpecie
	{
#nullable enable
		private static SpecieMarshtomp? _instance = null;
#nullable restore
        public static SpecieMarshtomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarshtomp();
                }
                return _instance;
            }
        }

		public SpecieMarshtomp() : base(
			"Marshtomp",
			70, // HPs
			85, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			50			
		) {}
	}


	//Marshtomp Pokemon Class
	public class Marshtomp : Pokemon
	{

		public Marshtomp(string nickname, int level)
		: base(
				259,
				SpecieMarshtomp.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Marshtomp(int level)
		: base(
				259,
				SpecieMarshtomp.Instance, // Pokemon Specie
				"Marshtomp", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Marshtomp() : base(
			259,
			SpecieMarshtomp.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}