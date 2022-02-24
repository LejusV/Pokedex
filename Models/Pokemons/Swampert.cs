using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swampert Specie to store common natural stats of every {'abilities': ['torrent', 'damp'], 'base_experience': 241, 'height': 15, 'id': 260, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'bide', 'waterfall', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'outrage', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'focus-punch', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'dive', 'mud-sport', 'hydro-cannon', 'rock-tomb', 'muddy-water', 'mud-shot', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'aqua-tail', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'mud-bomb', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'sludge-wave', 'round', 'echoed-voice', 'scald', 'water-pledge', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'swampert', 'stats': {'hp': 100, 'attack': 110, 'defense': 90, 'special-attack': 85, 'special-defense': 90, 'speed': 60}, 'types': ['water', 'ground'], 'weight': 819, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ラグラージ', 'roomaji': 'Laglarge', 'ko': '대짱이', 'zh-Hant': '巨沼怪', 'fr': 'Laggron', 'de': 'Sumpex', 'es': 'Swampert', 'it': 'Swampert', 'en': 'Swampert', 'ja': 'ラグラージ', 'zh-Hans': '巨沼怪'}, 'genera': {'ja-Hrkt': 'ぬまうおポケモン', 'ko': '늪물고기포켓몬', 'zh-Hant': '沼魚寶可夢', 'fr': 'Pokémon Poissonboue', 'de': 'Lehmhüpfer', 'es': 'Pokémon Pez Lodo', 'it': 'Pokémon Fango Pesce', 'en': 'Mud Fish Pokémon', 'ja': 'ぬまうおポケモン', 'zh-Hans': '沼鱼宝可梦'}}
	public class SpecieSwampert : PokemonSpecie
	{
#nullable enable
		private static SpecieSwampert? _instance = null;
#nullable restore
        public static SpecieSwampert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwampert();
                }
                return _instance;
            }
        }

		public SpecieSwampert() : base(
			"Swampert",
			100, // HPs
			110, 90, // Attack & Defense
			85, 90, // Special Attack & Defense
			60			
		) {}
	}


	//Swampert Pokemon Class
	public class Swampert : Pokemon
	{

		public Swampert(string nickname, int level)
		: base(
				260,
				SpecieSwampert.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swampert(int level)
		: base(
				260,
				SpecieSwampert.Instance, // Pokemon Specie
				"Swampert", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swampert() : base(
			260,
			SpecieSwampert.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}