using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxicroak Specie to store common natural stats of every {'abilities': ['anticipation', 'dry-skin', 'poison-touch'], 'base_experience': 172, 'height': 13, 'id': 454, 'moves': ['ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'headbutt', 'poison-sting', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'torment', 'flatter', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'revenge', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'bulk-up', 'bounce', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'poison-jab', 'dark-pulse', 'x-scissor', 'drain-punch', 'vacuum-wave', 'focus-blast', 'giga-impact', 'nasty-plot', 'mud-bomb', 'rock-climb', 'gunk-shot', 'stone-edge', 'captivate', 'venoshock', 'sludge-wave', 'low-sweep', 'foul-play', 'round', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'belch', 'confide', 'power-up-punch'], 'name': 'toxicroak', 'stats': {'hp': 83, 'attack': 106, 'defense': 65, 'special-attack': 86, 'special-defense': 65, 'speed': 85}, 'types': ['poison', 'fighting'], 'weight': 444, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ドクロッグ', 'roomaji': 'Dokurog', 'ko': '독개굴', 'zh-Hant': '毒骷蛙', 'fr': 'Coatox', 'de': 'Toxiquak', 'es': 'Toxicroak', 'it': 'Toxicroak', 'en': 'Toxicroak', 'ja': 'ドクロッグ', 'zh-Hans': '毒骷蛙'}, 'genera': {'ja-Hrkt': 'どくづきポケモン', 'ko': '독설포켓몬', 'zh-Hant': '毒擊寶可夢', 'fr': 'Pokémon Toxique', 'de': 'Giftmund', 'es': 'Pokémon Boca Tóxica', 'it': 'Pokémon Inveieleno', 'en': 'Toxic Mouth Pokémon', 'ja': 'どくづきポケモン', 'zh-Hans': '毒击宝可梦'}}
	public class SpecieToxicroak : PokemonSpecie
	{
#nullable enable
		private static SpecieToxicroak? _instance = null;
#nullable restore
        public static SpecieToxicroak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxicroak();
                }
                return _instance;
            }
        }

		public SpecieToxicroak() : base(
			"Toxicroak",
			83, // HPs
			106, 65, // Attack & Defense
			86, 65, // Special Attack & Defense
			85			
		) {}
	}


	//Toxicroak Pokemon Class
	public class Toxicroak : Pokemon
	{

		public Toxicroak(string nickname, int level) : base(
			454,
			SpecieToxicroak.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Fighting.Instance			
		) {}

		public Toxicroak() : base(
			454,
			SpecieToxicroak.Instance, // Pokemon Specie
			Poison.Instance, Fighting.Instance			
		) {}
	}
}