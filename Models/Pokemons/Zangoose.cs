using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zangoose Specie to store common natural stats of every {'abilities': ['immunity', 'toxic-boost'], 'base_experience': 160, 'height': 13, 'id': 335, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'razor-wind', 'swords-dance', 'double-kick', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'roar', 'disable', 'flamethrower', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'defense-curl', 'fire-blast', 'swift', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'detect', 'giga-drain', 'endure', 'rollout', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'revenge', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'crush-claw', 'rock-tomb', 'aerial-ace', 'shock-wave', 'water-pulse', 'natural-gift', 'feint', 'close-combat', 'payback', 'embargo', 'fling', 'last-resort', 'poison-jab', 'night-slash', 'x-scissor', 'focus-blast', 'shadow-claw', 'rock-climb', 'captivate', 'double-hit', 'hone-claws', 'round', 'quick-guard', 'incinerate', 'retaliate', 'final-gambit', 'work-up', 'confide', 'power-up-punch'], 'name': 'zangoose', 'stats': {'hp': 73, 'attack': 115, 'defense': 60, 'special-attack': 60, 'special-defense': 60, 'speed': 90}, 'types': ['normal'], 'weight': 403, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'white', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ザングース', 'roomaji': 'Zangoose', 'ko': '쟝고', 'zh-Hant': '貓鼬斬', 'fr': 'Mangriff', 'de': 'Sengo', 'es': 'Zangoose', 'it': 'Zangoose', 'en': 'Zangoose', 'ja': 'ザングース', 'zh-Hans': '猫鼬斩'}, 'genera': {'ja-Hrkt': 'ネコイタチポケモン', 'ko': '고양이족제비포켓몬', 'zh-Hant': '貓鼬寶可夢', 'fr': 'Pokémon Chat Furet', 'de': 'Frettkatz', 'es': 'Pokémon Gato Hurón', 'it': 'Pokémon Furogatto', 'en': 'Cat Ferret Pokémon', 'ja': 'ネコイタチポケモン', 'zh-Hans': '猫鼬宝可梦'}}
	public class SpecieZangoose : PokemonSpecie
	{
#nullable enable
		private static SpecieZangoose? _instance = null;
#nullable restore
        public static SpecieZangoose Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZangoose();
                }
                return _instance;
            }
        }

		public SpecieZangoose() : base(
			"Zangoose",
			73, // HPs
			115, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			90			
		) {}
	}


	//Zangoose Pokemon Class
	public class Zangoose : Pokemon
	{

		public Zangoose(string nickname, int level) : base(
			335,
			SpecieZangoose.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Zangoose() : base(
			335,
			SpecieZangoose.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}