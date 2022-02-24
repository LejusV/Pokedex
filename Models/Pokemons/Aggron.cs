using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aggron Specie to store common natural stats of every {'abilities': ['sturdy', 'rock-head', 'heavy-metal'], 'base_experience': 239, 'height': 21, 'id': 306, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'spite', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'shock-wave', 'water-pulse', 'natural-gift', 'metal-burst', 'payback', 'fling', 'magnet-rise', 'rock-polish', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'flash-cannon', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'autotomize', 'smack-down', 'heavy-slam', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'power-up-punch', 'smart-strike', 'brutal-swing'], 'name': 'aggron', 'stats': {'hp': 70, 'attack': 110, 'defense': 180, 'special-attack': 60, 'special-defense': 60, 'speed': 50}, 'types': ['steel', 'rock'], 'weight': 3600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ボスゴドラ', 'roomaji': 'Bossgodora', 'ko': '보스로라', 'zh-Hant': '波士可多拉', 'fr': 'Galeking', 'de': 'Stolloss', 'es': 'Aggron', 'it': 'Aggron', 'en': 'Aggron', 'ja': 'ボスゴドラ', 'zh-Hans': '波士可多拉'}, 'genera': {'ja-Hrkt': 'てつヨロイポケモン', 'ko': '철갑옷포켓몬', 'zh-Hant': '鐵鎧寶可夢', 'fr': 'Pokémon Armurfer', 'de': 'Eisenpanzer', 'es': 'Pokémon Cor. Férrea', 'it': 'Pokémon Corazza', 'en': 'Iron Armor Pokémon', 'ja': 'てつヨロイポケモン', 'zh-Hans': '铁铠宝可梦'}}
	public class SpecieAggron : PokemonSpecie
	{
#nullable enable
		private static SpecieAggron? _instance = null;
#nullable restore
        public static SpecieAggron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAggron();
                }
                return _instance;
            }
        }

		public SpecieAggron() : base(
			"Aggron",
			70, // HPs
			110, 180, // Attack & Defense
			60, 60, // Special Attack & Defense
			50			
		) {}
	}


	//Aggron Pokemon Class
	public class Aggron : Pokemon
	{

		public Aggron(string nickname, int level)
		: base(
				306,
				SpecieAggron.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Aggron(int level)
		: base(
				306,
				SpecieAggron.Instance, // Pokemon Specie
				"Aggron", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Aggron() : base(
			306,
			SpecieAggron.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
	}
}